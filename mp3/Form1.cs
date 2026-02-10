using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NAudio.Wave; // Paquete NuGet: NAudio
using TagLib; // Paquete NuGet: TagLibSharp

namespace mp3
{
    public partial class Form1 : Form
    {
        // ==========================================
        // 1. PROPIEDADES Y VARIABLES GLOBALES
        // ==========================================

        // Reproductor de audio 
        private IWavePlayer outputDevice;
        private AudioFileReader audioFile;

        // Lista para guardar los datos de las canciones en memoria
        private List<Cancion> listaActualCanciones = new List<Cancion>();

        // Índice de la canción que suena actualmente
        private int indiceActual = -1;

        // Timer para actualizar la barra de progreso
        private Timer timerReproduccion;

        public Form1()
        {
            InitializeComponent();
            ConfigurarReproductor();
            ConfigurarEventos();
        }

        // ==========================================
        // 2. CONFIGURACIÓN INICIAL
        // ==========================================
        private void ConfigurarReproductor()
        {
            //inicializamos el reproductor de audio (NAudio)
            outputDevice = new WaveOutEvent();

            // Timer: se ejecutará cada segundo para mover la barra
            timerReproduccion = new Timer();
            timerReproduccion.Interval = 1000;
            timerReproduccion.Tick += TimerReproduccion_Tick;
        }

        private void ConfigurarEventos()
        {
            // Asignamos los clicks a los botones que creamos en el Designer
            btnImportarCarpeta.Click += BtnImportarCarpeta_Click;
            btnPlay.Click += BtnPlay_Click;
            btnSiguiente.Click += BtnSiguiente_Click;
            btnAnterior.Click += BtnAnterior_Click;

            // Evento al hacer doble click en una canción de la lista
            dgvCanciones.DoubleClick += DgvCanciones_DoubleClick;

            // Eventos de las barras (Volumen y Progreso)
            trackBarVolumen.Scroll += TrackBarVolumen_Scroll;
            trackBarProgreso.Scroll += TrackBarProgreso_Scroll;

            // Evento para detectar cuando una canción termina
            if (outputDevice.PlaybackState == PlaybackState.Playing)
            {
                outputDevice.Pause();
            }
        }

        // ==========================================
        // 3. LÓGICA DE IMPORTACIÓN (CLASE CANCIÓN)
        // ==========================================

        // CLASE: Definición de qué es una canción para nuestro sistema
        public class Cancion
        {
            public string Titulo { get; set; }
            public string Artista { get; set; }
            public string Album { get; set; }
            public string RutaArchivo { get; set; }
            public TimeSpan Duracion { get; set; }

            // Constructor simple
            public Cancion(string ruta)
            {
                RutaArchivo = ruta;
                // Leemos los metadatos con TagLib
                var archivo = TagLib.File.Create(ruta);
                Titulo = archivo.Tag.Title ?? Path.GetFileNameWithoutExtension(ruta);
                Artista = archivo.Tag.FirstPerformer ?? "Desconocido";
                Album = archivo.Tag.Album ?? "Single";
                Duracion = archivo.Properties.Duration;
            }
        }

        private void BtnImportarCarpeta_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    CargarCancionesDeCarpeta(fbd.SelectedPath);
                }
            }
        }

        private void CargarCancionesDeCarpeta(string rutaCarpeta)
        {
            // Limpiamos listas anteriores
            listaActualCanciones.Clear();
            dgvCanciones.Rows.Clear();

            string[] archivos = Directory.GetFiles(rutaCarpeta, "*.mp3", SearchOption.AllDirectories);

            foreach (string archivo in archivos)
            {
                try
                {
                    // Creamos el objeto Cancion
                    Cancion nuevaCancion = new Cancion(archivo);
                    listaActualCanciones.Add(nuevaCancion);

                    // Lo agregamos visualmente al DataGridView
                    dgvCanciones.Rows.Add(nuevaCancion.Titulo, nuevaCancion.Artista, nuevaCancion.Duracion.ToString(@"mm\:ss"));
                }
                catch
                {
                    // Si un archivo falla, lo ignoramos y seguimos
                }
            }
        }

        // ==========================================
        // 4. LÓGICA DE REPRODUCCIÓN
        // ==========================================

        private void ReproducirCancion(int indice)
        {
            if (indice < 0 || indice >= listaActualCanciones.Count) return;

            indiceActual = indice;
            Cancion cancion = listaActualCanciones[indice];

            // Detener y liberar recursos anteriores si existen
            outputDevice?.Stop();
            audioFile?.Dispose();

            // Cargar nuevo archivo
            audioFile = new AudioFileReader(cancion.RutaArchivo);
            outputDevice.Init(audioFile);
            outputDevice.Play();

            // Actualizar Interfaz
            btnPlay.Text = "⏸";
            timerReproduccion.Start();
            lblTituloCancion.Text = cancion.Titulo;
            lblArtista.Text = cancion.Artista;
            lblAlbum.Text = cancion.Album;
            lblTiempoTotal.Text = cancion.Duracion.ToString(@"mm\:ss");

            CargarPortada(cancion.RutaArchivo);
        }
        private void CargarPortada(string rutaArchivo)
        {
            try
            {
                var archivo = TagLib.File.Create(rutaArchivo);
                if (archivo.Tag.Pictures.Length > 0)
                {
                    // Convertimos los bytes de la imagen a un Bitmap
                    var bin = (byte[])(archivo.Tag.Pictures[0].Data.Data);
                    using (MemoryStream ms = new MemoryStream(bin))
                    {
                        picPortada.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    // Si no tiene portada, poner una por defecto (opcional)
                    picPortada.Image = null;
                }
            }
            catch
            {
                picPortada.Image = null;
            }
        }

        // ==========================================
        // 5. CONTROLADORES DE EVENTOS (BOTONES)
        // ==========================================

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (outputDevice == null || audioFile == null) return;

            if (outputDevice.PlaybackState == PlaybackState.Playing)
            {
                outputDevice.Pause();
                timerReproduccion.Stop();
                btnPlay.Text = "▶";
            }
            else
            {
                outputDevice.Play();
                timerReproduccion.Start();
                btnPlay.Text = "⏸";
            }
        }
        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            if (indiceActual < listaActualCanciones.Count - 1)
            {
                ReproducirCancion(indiceActual + 1);
            }
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            if (indiceActual > 0)
            {
                ReproducirCancion(indiceActual - 1);
            }
        }

        private void DgvCanciones_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCanciones.SelectedRows.Count > 0)
            {
                ReproducirCancion(dgvCanciones.SelectedRows[0].Index);
            }
        }

        // ==========================================
        // 6. CONTROLADORES DE BARRAS Y TIMER
        // ==========================================

        private void TimerReproduccion_Tick(object sender, EventArgs e)
        {
            if (audioFile != null && outputDevice.PlaybackState == PlaybackState.Playing)
            {
                trackBarProgreso.Maximum = (int)audioFile.TotalTime.TotalSeconds;
                trackBarProgreso.Value = (int)audioFile.CurrentTime.TotalSeconds;
                lblTiempoActual.Text = audioFile.CurrentTime.ToString(@"mm\:ss");
            }
        }

 private void TrackBarVolumen_Scroll(object sender, EventArgs e)
{
    if (audioFile != null)
    {
        // NAudio usa valores de 0.0f a 1.0f
        audioFile.Volume = trackBarVolumen.Value / 100f;
        lblVolumen.Text = trackBarVolumen.Value + "%";
    }
}
        private void TrackBarProgreso_Scroll(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                audioFile.CurrentTime = TimeSpan.FromSeconds(trackBarProgreso.Value);
            }
        }
        // Detectar cuando termina una canción para pasar a la siguiente automáticamente
        private void Player_PlayStateChange(int NewState)
        {
            outputDevice.PlaybackStopped += (s, a) => {
                // Lógica para saltar a la siguiente canción cuando termine la actual
                if (indiceActual < listaActualCanciones.Count - 1)
                    ReproducirCancion(indiceActual + 1);
            };
        }
    }
}