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
        // IWavePlayer es una interfaz de NAudio que representa un dispositivo de reproducción de audio.
        private IWavePlayer outputDevice;
        // AudioFileReader es una clase de NAudio que facilita la lectura de archivos de audio. 
        private AudioFileReader audioFile;

        // Lista para guardar los datos de las canciones en memoria
        private List<Cancion> listaActualCanciones = new List<Cancion>();

        // Índice de la canción que suena actualmente
        private int indiceActual = -1;

        // Timer para actualizar la barra de progreso
        private Timer timerReproduccion;

        private string rutaMisListas = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));

        // menu click derecho
        private ContextMenuStrip menuCanciones;

        public Form1()
        {
            InitializeComponent();
            ConfigurarReproductor();
            ConfigurarEventos();
            CargarListasEnSidebar();// Cargar las listas guardadas al iniciar la aplicación
            InicializarMenuContextual(); // Configurar el menú contextual para añadir canciones a las listas desde la interfaz de reproducción
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
            // Asignamos los clicks a los botones
            btnImportarCarpeta.Click += BtnImportarCarpeta_Click;
            btnPlay.Click += BtnPlay_Click;
            btnSiguiente.Click += BtnSiguiente_Click;
            btnAnterior.Click += BtnAnterior_Click;

            // Guardar lista (Botón Nueva Lista)
            btnNuevaLista.Click += BtnGuardarLista_Click;

            // Evento al hacer doble click en una canción de la grilla
            dgvCanciones.DoubleClick += DgvCanciones_DoubleClick;

            // Evento al hacer doble click en una Playlist (Barra lateral)
            lstPlaylists.DoubleClick += LstPlaylists_DoubleClick;

            // Eventos de las barras
            trackBarVolumen.Scroll += TrackBarVolumen_Scroll;
            trackBarProgreso.Scroll += TrackBarProgreso_Scroll;

            // CORRECCIÓN IMPORTANTE: Así se programa el salto automático de canción
            outputDevice.PlaybackStopped += (s, a) =>
            {
                // Si la canción terminó sola (y no fue stop manual), pasar a la siguiente
                if (indiceActual < listaActualCanciones.Count - 1)
                {
                    ReproducirCancion(indiceActual + 1);
                }
            };
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

        // Guardar lista nueva
        private void BtnGuardarLista_Click(object sender, EventArgs e)
        {
            // Usamos el SaveFileDialog solo para que escribas el NOMBRE de la carpeta
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.InitialDirectory = rutaMisListas;
                sfd.FileName = "Nueva Lista";
                sfd.Title = "Crear nueva carpeta de playlist";
                sfd.Filter = "Carpeta|*.";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string nombreCarpeta = Path.GetFileNameWithoutExtension(sfd.FileName);
                        string rutaNuevaCarpeta = Path.Combine(rutaMisListas, nombreCarpeta);

                        // 1. Solo creamos la carpeta vacía
                        if (!Directory.Exists(rutaNuevaCarpeta))
                        {
                            Directory.CreateDirectory(rutaNuevaCarpeta);
                            MessageBox.Show($"Lista '{nombreCarpeta}'.");
                        }
                        else
                        {
                            MessageBox.Show("Esa lista ya existe.");
                        }

                        // 2. Actualizamos la barra lateral para que aparezca
                        CargarListasEnSidebar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error ." + ex.Message);
                    }
                }
            }
        }
        private void CargarListasEnSidebar()
        {
            if (!Directory.Exists(rutaMisListas))
            {
                Directory.CreateDirectory(rutaMisListas);
            }

            // 2. Limpiar la lista visual 
            lstPlaylists.Items.Clear();

            string[] carpetas = Directory.GetDirectories(rutaMisListas);

            // 4. Agregarlos a la lista (solo el nombre, sin la ruta completa)
            foreach (string carpeta in carpetas)
            {
                string nombreLista = Path.GetFileNameWithoutExtension(carpeta);
                lstPlaylists.Items.Add(nombreLista);
            }
        }

        private void LstPlaylists_DoubleClick(object sender, EventArgs e)
        {
            if (lstPlaylists.SelectedItem == null) return;

            // 1. Construir la ruta de la carpeta seleccionada
            string nombreCarpeta = lstPlaylists.SelectedItem.ToString();
            string rutaCompleta = Path.Combine(rutaMisListas, nombreCarpeta);

            if (Directory.Exists(rutaCompleta))
            {
                
                CargarCancionesDeCarpeta(rutaCompleta);
            }
        }

        private void AgregarCancionALista(string nombreLista, Cancion cancion)
        {
            // Rutas
            string rutaCarpetaDestino = Path.Combine(rutaMisListas, nombreLista);
            string nombreArchivo = Path.GetFileName(cancion.RutaArchivo);
            string rutaDestinoFinal = Path.Combine(rutaCarpetaDestino, nombreArchivo);

            try
            {
                // 1. Verificamos que sea una carpeta real
                if (Directory.Exists(rutaCarpetaDestino))
                {
                    // 2. COPIAR EL ARCHIVO MP3 (Usando System.IO explícitamente)
                    System.IO.File.Copy(cancion.RutaArchivo, rutaDestinoFinal, true);

                    MessageBox.Show($"Canción copiada a la carpeta: {nombreLista}");
                }
                else
                {
                    MessageBox.Show("Error: No se encuentra la carpeta de destino.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al copiar: " + ex.Message);
            }
        }

        private void InicializarMenuContextual()
        {
            menuCanciones = new ContextMenuStrip();

            // Este evento se dispara justo antes de que el menú se abra visualmente
            menuCanciones.Opening += (sender, e) =>
            {
                // 1. Limpiamos opciones viejas
                menuCanciones.Items.Clear();

                // 2. Verificamos que haya una canción seleccionada
                if (dgvCanciones.SelectedRows.Count == 0)
                {
                    e.Cancel = true; // No abrir si no hay selección
                    return;
                }

                // 3. Crear el item principal "Añadir a..."
                ToolStripMenuItem itemAnadir = new ToolStripMenuItem("Añadir a playlist");

                // 4. Recorremos las listas que tienes en la barra lateral
                foreach (var itemLista in lstPlaylists.Items)
                {
                    string nombreLista = itemLista.ToString();

                    // Creamos un sub-item por cada lista
                    ToolStripMenuItem subItem = new ToolStripMenuItem(nombreLista);

                    // Qué pasa cuando le das clic a esa lista específica
                    subItem.Click += (s, args) =>
                    {
                        // Obtenemos la canción seleccionada actualmente
                        int indice = dgvCanciones.SelectedRows[0].Index;
                        Cancion cancionSeleccionada = listaActualCanciones[indice];

                        // Llamamos al método que creamos en el Paso 2
                        AgregarCancionALista(nombreLista, cancionSeleccionada);
                    };

                    itemAnadir.DropDownItems.Add(subItem);
                }

                // Si no tienes listas creadas, mostramos un aviso o deshabilitamos
                if (lstPlaylists.Items.Count == 0)
                {
                    itemAnadir.DropDownItems.Add(new ToolStripMenuItem("(No hay listas creadas)") { Enabled = false });
                }

                menuCanciones.Items.Add(itemAnadir);
            };

            // Asignar este menú al DataGridView
            dgvCanciones.ContextMenuStrip = menuCanciones;
        }
    }
}