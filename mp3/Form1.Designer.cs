namespace mp3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnImportarCarpeta = new System.Windows.Forms.Button();
            this.lblTituloPlaylists = new System.Windows.Forms.Label();
            this.lstPlaylists = new System.Windows.Forms.ListBox();
            this.btnNuevaLista = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlReproduccion = new System.Windows.Forms.Panel();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.trackBarVolumen = new System.Windows.Forms.TrackBar();
            this.lblTiempoTotal = new System.Windows.Forms.Label();
            this.lblTiempoActual = new System.Windows.Forms.Label();
            this.trackBarProgreso = new System.Windows.Forms.TrackBar();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.dgvCanciones = new System.Windows.Forms.DataGridView();
            this.colTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArtista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelInfoCancion = new System.Windows.Forms.Panel();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.lblArtista = new System.Windows.Forms.Label();
            this.lblTituloCancion = new System.Windows.Forms.Label();
            this.picPortada = new System.Windows.Forms.PictureBox();
            this.pnlSidebar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlReproduccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProgreso)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanciones)).BeginInit();
            this.panelInfoCancion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pnlSidebar.Controls.Add(this.btnImportarCarpeta);
            this.pnlSidebar.Controls.Add(this.lblTituloPlaylists);
            this.pnlSidebar.Controls.Add(this.lstPlaylists);
            this.pnlSidebar.Controls.Add(this.btnNuevaLista);
            this.pnlSidebar.Controls.Add(this.pnlLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 561);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnImportarCarpeta
            // 
            this.btnImportarCarpeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnImportarCarpeta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnImportarCarpeta.FlatAppearance.BorderSize = 0;
            this.btnImportarCarpeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportarCarpeta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportarCarpeta.ForeColor = System.Drawing.Color.LightGray;
            this.btnImportarCarpeta.Location = new System.Drawing.Point(0, 516);
            this.btnImportarCarpeta.Name = "btnImportarCarpeta";
            this.btnImportarCarpeta.Size = new System.Drawing.Size(220, 45);
            this.btnImportarCarpeta.TabIndex = 4;
            this.btnImportarCarpeta.Text = "📁 Importar Carpeta";
            this.btnImportarCarpeta.UseVisualStyleBackColor = false;
            // 
            // lblTituloPlaylists
            // 
            this.lblTituloPlaylists.AutoSize = true;
            this.lblTituloPlaylists.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPlaylists.ForeColor = System.Drawing.Color.Gray;
            this.lblTituloPlaylists.Location = new System.Drawing.Point(12, 120);
            this.lblTituloPlaylists.Name = "lblTituloPlaylists";
            this.lblTituloPlaylists.Size = new System.Drawing.Size(91, 15);
            this.lblTituloPlaylists.TabIndex = 3;
            this.lblTituloPlaylists.Text = "TU BIBLIOTECA";
            // 
            // lstPlaylists
            // 
            this.lstPlaylists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.lstPlaylists.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPlaylists.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstPlaylists.ForeColor = System.Drawing.Color.White;
            this.lstPlaylists.FormattingEnabled = true;
            this.lstPlaylists.ItemHeight = 17;
            this.lstPlaylists.Items.AddRange(new object[] {
            "Canciones que me gustan",
            "Música para programar",
            "Rock Clásico"});
            this.lstPlaylists.Location = new System.Drawing.Point(15, 145);
            this.lstPlaylists.Name = "lstPlaylists";
            this.lstPlaylists.Size = new System.Drawing.Size(188, 306);
            this.lstPlaylists.TabIndex = 2;
            // 
            // btnNuevaLista
            // 
            this.btnNuevaLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnNuevaLista.FlatAppearance.BorderSize = 0;
            this.btnNuevaLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaLista.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaLista.ForeColor = System.Drawing.Color.Black;
            this.btnNuevaLista.Location = new System.Drawing.Point(15, 65);
            this.btnNuevaLista.Name = "btnNuevaLista";
            this.btnNuevaLista.Size = new System.Drawing.Size(188, 40);
            this.btnNuevaLista.TabIndex = 1;
            this.btnNuevaLista.Text = "+ Nueva Lista";
            this.btnNuevaLista.UseVisualStyleBackColor = false;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.lblLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(220, 59);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(12, 18);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(117, 25);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "🎵 MyPlayer";
            // 
            // pnlReproduccion
            // 
            this.pnlReproduccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnlReproduccion.Controls.Add(this.lblVolumen);
            this.pnlReproduccion.Controls.Add(this.trackBarVolumen);
            this.pnlReproduccion.Controls.Add(this.lblTiempoTotal);
            this.pnlReproduccion.Controls.Add(this.lblTiempoActual);
            this.pnlReproduccion.Controls.Add(this.trackBarProgreso);
            this.pnlReproduccion.Controls.Add(this.btnSiguiente);
            this.pnlReproduccion.Controls.Add(this.btnPlay);
            this.pnlReproduccion.Controls.Add(this.btnAnterior);
            this.pnlReproduccion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlReproduccion.Location = new System.Drawing.Point(220, 471);
            this.pnlReproduccion.Name = "pnlReproduccion";
            this.pnlReproduccion.Size = new System.Drawing.Size(764, 90);
            this.pnlReproduccion.TabIndex = 1;
            // 
            // lblVolumen
            // 
            this.lblVolumen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.ForeColor = System.Drawing.Color.Gray;
            this.lblVolumen.Location = new System.Drawing.Point(600, 39);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(22, 13);
            this.lblVolumen.TabIndex = 7;
            this.lblVolumen.Text = "Vol";
            // 
            // trackBarVolumen
            // 
            this.trackBarVolumen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarVolumen.Location = new System.Drawing.Point(628, 34);
            this.trackBarVolumen.Maximum = 100;
            this.trackBarVolumen.Name = "trackBarVolumen";
            this.trackBarVolumen.Size = new System.Drawing.Size(104, 45);
            this.trackBarVolumen.TabIndex = 6;
            this.trackBarVolumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarVolumen.Value = 50;
            // 
            // lblTiempoTotal
            // 
            this.lblTiempoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTiempoTotal.AutoSize = true;
            this.lblTiempoTotal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoTotal.ForeColor = System.Drawing.Color.Gray;
            this.lblTiempoTotal.Location = new System.Drawing.Point(690, 11);
            this.lblTiempoTotal.Name = "lblTiempoTotal";
            this.lblTiempoTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTiempoTotal.TabIndex = 5;
            this.lblTiempoTotal.Text = "00:00";
            // 
            // lblTiempoActual
            // 
            this.lblTiempoActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTiempoActual.AutoSize = true;
            this.lblTiempoActual.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoActual.ForeColor = System.Drawing.Color.Gray;
            this.lblTiempoActual.Location = new System.Drawing.Point(6, 11);
            this.lblTiempoActual.Name = "lblTiempoActual";
            this.lblTiempoActual.Size = new System.Drawing.Size(34, 13);
            this.lblTiempoActual.TabIndex = 4;
            this.lblTiempoActual.Text = "00:00";
            // 
            // trackBarProgreso
            // 
            this.trackBarProgreso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarProgreso.AutoSize = false;
            this.trackBarProgreso.Location = new System.Drawing.Point(46, 6);
            this.trackBarProgreso.Maximum = 100;
            this.trackBarProgreso.Name = "trackBarProgreso";
            this.trackBarProgreso.Size = new System.Drawing.Size(638, 26);
            this.trackBarProgreso.TabIndex = 3;
            this.trackBarProgreso.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(407, 39);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(40, 40);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "⏭";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(344, 30);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(57, 51);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "▶";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.Color.White;
            this.btnAnterior.Location = new System.Drawing.Point(298, 39);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(40, 40);
            this.btnAnterior.TabIndex = 0;
            this.btnAnterior.Text = "⏮";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlPrincipal.Controls.Add(this.dgvCanciones);
            this.pnlPrincipal.Controls.Add(this.panelInfoCancion);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(220, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(764, 471);
            this.pnlPrincipal.TabIndex = 2;
            // 
            // dgvCanciones
            // 
            this.dgvCanciones.AllowUserToAddRows = false;
            this.dgvCanciones.AllowUserToDeleteRows = false;
            this.dgvCanciones.AllowUserToResizeRows = false;
            this.dgvCanciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCanciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.dgvCanciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCanciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCanciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCanciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCanciones.ColumnHeadersHeight = 30;
            this.dgvCanciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTitulo,
            this.colArtista,
            this.colDuracion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCanciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCanciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCanciones.EnableHeadersVisualStyles = false;
            this.dgvCanciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.dgvCanciones.Location = new System.Drawing.Point(0, 179);
            this.dgvCanciones.MultiSelect = false;
            this.dgvCanciones.Name = "dgvCanciones";
            this.dgvCanciones.ReadOnly = true;
            this.dgvCanciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCanciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCanciones.RowHeadersVisible = false;
            this.dgvCanciones.RowTemplate.Height = 35;
            this.dgvCanciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCanciones.Size = new System.Drawing.Size(764, 292);
            this.dgvCanciones.TabIndex = 1;
            // 
            // colTitulo
            // 
            this.colTitulo.HeaderText = "TÍTULO";
            this.colTitulo.Name = "colTitulo";
            this.colTitulo.ReadOnly = true;
            // 
            // colArtista
            // 
            this.colArtista.HeaderText = "ARTISTA";
            this.colArtista.Name = "colArtista";
            this.colArtista.ReadOnly = true;
            // 
            // colDuracion
            // 
            this.colDuracion.FillWeight = 30F;
            this.colDuracion.HeaderText = "🕐";
            this.colDuracion.Name = "colDuracion";
            this.colDuracion.ReadOnly = true;
            // 
            // panelInfoCancion
            // 
            this.panelInfoCancion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelInfoCancion.Controls.Add(this.lblAlbum);
            this.panelInfoCancion.Controls.Add(this.lblArtista);
            this.panelInfoCancion.Controls.Add(this.lblTituloCancion);
            this.panelInfoCancion.Controls.Add(this.picPortada);
            this.panelInfoCancion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfoCancion.Location = new System.Drawing.Point(0, 0);
            this.panelInfoCancion.Name = "panelInfoCancion";
            this.panelInfoCancion.Size = new System.Drawing.Size(764, 179);
            this.panelInfoCancion.TabIndex = 0;
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAlbum.ForeColor = System.Drawing.Color.Gray;
            this.lblAlbum.Location = new System.Drawing.Point(200, 115);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(117, 20);
            this.lblAlbum.TabIndex = 3;
            this.lblAlbum.Text = "Nombre Álbum";
            // 
            // lblArtista
            // 
            this.lblArtista.AutoSize = true;
            this.lblArtista.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblArtista.ForeColor = System.Drawing.Color.LightGray;
            this.lblArtista.Location = new System.Drawing.Point(200, 85);
            this.lblArtista.Name = "lblArtista";
            this.lblArtista.Size = new System.Drawing.Size(136, 25);
            this.lblArtista.TabIndex = 2;
            this.lblArtista.Text = "Artista Famoso";
            // 
            // lblTituloCancion
            // 
            this.lblTituloCancion.AutoSize = true;
            this.lblTituloCancion.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCancion.ForeColor = System.Drawing.Color.White;
            this.lblTituloCancion.Location = new System.Drawing.Point(196, 35);
            this.lblTituloCancion.Name = "lblTituloCancion";
            this.lblTituloCancion.Size = new System.Drawing.Size(325, 45);
            this.lblTituloCancion.TabIndex = 1;
            this.lblTituloCancion.Text = "Título de la Canción";
            // 
            // picPortada
            // 
            this.picPortada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.picPortada.Location = new System.Drawing.Point(25, 25);
            this.picPortada.Name = "picPortada";
            this.picPortada.Size = new System.Drawing.Size(150, 150);
            this.picPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPortada.TabIndex = 0;
            this.picPortada.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlReproduccion);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reproductor MP3 Moderno";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlReproduccion.ResumeLayout(false);
            this.pnlReproduccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProgreso)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanciones)).EndInit();
            this.panelInfoCancion.ResumeLayout(false);
            this.panelInfoCancion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPortada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlReproduccion;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnNuevaLista;
        private System.Windows.Forms.ListBox lstPlaylists;
        private System.Windows.Forms.Label lblTituloPlaylists;
        private System.Windows.Forms.Button btnImportarCarpeta;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.TrackBar trackBarProgreso;
        private System.Windows.Forms.Label lblTiempoTotal;
        private System.Windows.Forms.Label lblTiempoActual;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.TrackBar trackBarVolumen;
        private System.Windows.Forms.Panel panelInfoCancion;
        private System.Windows.Forms.PictureBox picPortada;
        private System.Windows.Forms.Label lblTituloCancion;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Label lblArtista;
        private System.Windows.Forms.DataGridView dgvCanciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArtista;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuracion;
    }
}