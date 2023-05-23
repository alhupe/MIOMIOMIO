
namespace PIDeffine
{
    partial class FrmTienda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTienda));
            this.paneldecontrol = new System.Windows.Forms.Panel();
            this.pcbCerrar = new System.Windows.Forms.PictureBox();
            this.pcbMinimizar = new System.Windows.Forms.PictureBox();
            this.pcbLogOut = new System.Windows.Forms.PictureBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.lblTalla = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblColecciones = new System.Windows.Forms.Label();
            this.lblMaximo = new System.Windows.Forms.Label();
            this.lblMinimo = new System.Windows.Forms.Label();
            this.lblContacta = new System.Windows.Forms.Label();
            this.cmbTalla = new System.Windows.Forms.ComboBox();
            this.panelPrinc = new System.Windows.Forms.Panel();
            this.panelColecciones = new System.Windows.Forms.Panel();
            this.rdTodo = new System.Windows.Forms.RadioButton();
            this.rdbPantalones = new System.Windows.Forms.RadioButton();
            this.rdbCamisetas = new System.Windows.Forms.RadioButton();
            this.pcbCarrito = new System.Windows.Forms.PictureBox();
            this.bttDesign = new System.Windows.Forms.Button();
            this.pcbPerfil = new System.Windows.Forms.PictureBox();
            this.bttFiltrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcbspain = new System.Windows.Forms.PictureBox();
            this.pcbingle = new System.Windows.Forms.PictureBox();
            this.pcbFiltros = new System.Windows.Forms.PictureBox();
            this.pcbPrincipal = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBorrarFiltros = new System.Windows.Forms.Button();
            this.txtPrecioMin = new System.Windows.Forms.TextBox();
            this.txtPrecioMax = new System.Windows.Forms.TextBox();
            this.rdbBandas = new System.Windows.Forms.RadioButton();
            this.rdbSeries = new System.Windows.Forms.RadioButton();
            this.rdbVideojuegos = new System.Windows.Forms.RadioButton();
            this.paneldecontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogOut)).BeginInit();
            this.panelColecciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbspain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbingle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFiltros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // paneldecontrol
            // 
            this.paneldecontrol.BackColor = System.Drawing.Color.DimGray;
            this.paneldecontrol.Controls.Add(this.pcbCerrar);
            this.paneldecontrol.Controls.Add(this.pcbMinimizar);
            this.paneldecontrol.Controls.Add(this.pcbLogOut);
            this.paneldecontrol.Location = new System.Drawing.Point(-6, -14);
            this.paneldecontrol.Name = "paneldecontrol";
            this.paneldecontrol.Size = new System.Drawing.Size(1022, 55);
            this.paneldecontrol.TabIndex = 24;
            this.paneldecontrol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneldecontrol_MouseDown);
            this.paneldecontrol.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paneldecontrol_MouseMove);
            this.paneldecontrol.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paneldecontrol_MouseUp);
            // 
            // pcbCerrar
            // 
            this.pcbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbCerrar.Image = global::PIDeffine.Properties.Resources.cerrar;
            this.pcbCerrar.Location = new System.Drawing.Point(953, 17);
            this.pcbCerrar.Name = "pcbCerrar";
            this.pcbCerrar.Size = new System.Drawing.Size(41, 35);
            this.pcbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCerrar.TabIndex = 24;
            this.pcbCerrar.TabStop = false;
            this.pcbCerrar.Click += new System.EventHandler(this.pcbCerrar_Click);
            // 
            // pcbMinimizar
            // 
            this.pcbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbMinimizar.Image = global::PIDeffine.Properties.Resources.minimizzar;
            this.pcbMinimizar.Location = new System.Drawing.Point(910, 17);
            this.pcbMinimizar.Name = "pcbMinimizar";
            this.pcbMinimizar.Size = new System.Drawing.Size(37, 35);
            this.pcbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMinimizar.TabIndex = 0;
            this.pcbMinimizar.TabStop = false;
            this.pcbMinimizar.Click += new System.EventHandler(this.pcbMinimizar_Click);
            // 
            // pcbLogOut
            // 
            this.pcbLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbLogOut.Image = global::PIDeffine.Properties.Resources.loguott;
            this.pcbLogOut.Location = new System.Drawing.Point(17, 17);
            this.pcbLogOut.Name = "pcbLogOut";
            this.pcbLogOut.Size = new System.Drawing.Size(38, 35);
            this.pcbLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogOut.TabIndex = 26;
            this.pcbLogOut.TabStop = false;
            this.pcbLogOut.Click += new System.EventHandler(this.pcbLogOut_Click);
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.ForeColor = System.Drawing.Color.White;
            this.lblIdioma.Location = new System.Drawing.Point(112, 100);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(70, 25);
            this.lblIdioma.TabIndex = 29;
            this.lblIdioma.Text = "Idioma";
            // 
            // lblTalla
            // 
            this.lblTalla.AutoSize = true;
            this.lblTalla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTalla.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline);
            this.lblTalla.ForeColor = System.Drawing.Color.White;
            this.lblTalla.Location = new System.Drawing.Point(40, 565);
            this.lblTalla.Name = "lblTalla";
            this.lblTalla.Size = new System.Drawing.Size(50, 23);
            this.lblTalla.TabIndex = 33;
            this.lblTalla.Text = "Talla";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblPrecio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(40, 292);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(66, 23);
            this.lblPrecio.TabIndex = 34;
            this.lblPrecio.Text = "Precio";
            // 
            // lblColecciones
            // 
            this.lblColecciones.AutoSize = true;
            this.lblColecciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblColecciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColecciones.ForeColor = System.Drawing.Color.White;
            this.lblColecciones.Location = new System.Drawing.Point(38, 411);
            this.lblColecciones.Name = "lblColecciones";
            this.lblColecciones.Size = new System.Drawing.Size(116, 23);
            this.lblColecciones.TabIndex = 35;
            this.lblColecciones.Text = "Colecciones";
            // 
            // lblMaximo
            // 
            this.lblMaximo.AutoSize = true;
            this.lblMaximo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblMaximo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximo.ForeColor = System.Drawing.Color.White;
            this.lblMaximo.Location = new System.Drawing.Point(38, 361);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(78, 23);
            this.lblMaximo.TabIndex = 44;
            this.lblMaximo.Text = "Máximo";
            // 
            // lblMinimo
            // 
            this.lblMinimo.AutoSize = true;
            this.lblMinimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblMinimo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimo.ForeColor = System.Drawing.Color.White;
            this.lblMinimo.Location = new System.Drawing.Point(38, 325);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(74, 23);
            this.lblMinimo.TabIndex = 45;
            this.lblMinimo.Text = "Mínimo";
            // 
            // lblContacta
            // 
            this.lblContacta.AutoSize = true;
            this.lblContacta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblContacta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacta.ForeColor = System.Drawing.Color.White;
            this.lblContacta.Location = new System.Drawing.Point(638, 100);
            this.lblContacta.Name = "lblContacta";
            this.lblContacta.Size = new System.Drawing.Size(211, 25);
            this.lblContacta.TabIndex = 47;
            this.lblContacta.Text = "Contacta con Nosotros";
            this.lblContacta.Click += new System.EventHandler(this.lblContacta_Click);
            // 
            // cmbTalla
            // 
            this.cmbTalla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTalla.Items.AddRange(new object[] {
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "XXL"});
            this.cmbTalla.Location = new System.Drawing.Point(45, 602);
            this.cmbTalla.Name = "cmbTalla";
            this.cmbTalla.Size = new System.Drawing.Size(193, 31);
            this.cmbTalla.TabIndex = 0;
            this.cmbTalla.SelectedIndexChanged += new System.EventHandler(this.cmbTalla_SelectedIndexChanged);
            // 
            // panelPrinc
            // 
            this.panelPrinc.AutoScroll = true;
            this.panelPrinc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panelPrinc.Location = new System.Drawing.Point(270, 198);
            this.panelPrinc.Name = "panelPrinc";
            this.panelPrinc.Size = new System.Drawing.Size(698, 531);
            this.panelPrinc.TabIndex = 68;
            // 
            // panelColecciones
            // 
            this.panelColecciones.AutoScroll = true;
            this.panelColecciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panelColecciones.Controls.Add(this.rdTodo);
            this.panelColecciones.Controls.Add(this.rdbVideojuegos);
            this.panelColecciones.Controls.Add(this.rdbSeries);
            this.panelColecciones.Controls.Add(this.rdbBandas);
            this.panelColecciones.Controls.Add(this.rdbPantalones);
            this.panelColecciones.Controls.Add(this.rdbCamisetas);
            this.panelColecciones.ForeColor = System.Drawing.Color.White;
            this.panelColecciones.Location = new System.Drawing.Point(36, 437);
            this.panelColecciones.Name = "panelColecciones";
            this.panelColecciones.Size = new System.Drawing.Size(228, 99);
            this.panelColecciones.TabIndex = 0;
            // 
            // rdTodo
            // 
            this.rdTodo.AutoSize = true;
            this.rdTodo.Checked = true;
            this.rdTodo.Location = new System.Drawing.Point(3, 3);
            this.rdTodo.Name = "rdTodo";
            this.rdTodo.Size = new System.Drawing.Size(74, 27);
            this.rdTodo.TabIndex = 3;
            this.rdTodo.TabStop = true;
            this.rdTodo.Text = "Todo";
            this.rdTodo.UseVisualStyleBackColor = true;
            // 
            // rdbPantalones
            // 
            this.rdbPantalones.AutoSize = true;
            this.rdbPantalones.Location = new System.Drawing.Point(3, 64);
            this.rdbPantalones.Name = "rdbPantalones";
            this.rdbPantalones.Size = new System.Drawing.Size(128, 27);
            this.rdbPantalones.TabIndex = 1;
            this.rdbPantalones.Text = "Pantalones";
            this.rdbPantalones.UseVisualStyleBackColor = true;
            // 
            // rdbCamisetas
            // 
            this.rdbCamisetas.AutoSize = true;
            this.rdbCamisetas.Location = new System.Drawing.Point(3, 31);
            this.rdbCamisetas.Name = "rdbCamisetas";
            this.rdbCamisetas.Size = new System.Drawing.Size(124, 27);
            this.rdbCamisetas.TabIndex = 0;
            this.rdbCamisetas.Text = "Camisetas";
            this.rdbCamisetas.UseVisualStyleBackColor = true;
            // 
            // pcbCarrito
            // 
            this.pcbCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbCarrito.Image = global::PIDeffine.Properties.Resources.Carrito1;
            this.pcbCarrito.Location = new System.Drawing.Point(927, 89);
            this.pcbCarrito.Name = "pcbCarrito";
            this.pcbCarrito.Size = new System.Drawing.Size(51, 50);
            this.pcbCarrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCarrito.TabIndex = 71;
            this.pcbCarrito.TabStop = false;
            this.pcbCarrito.Click += new System.EventHandler(this.pcbCarrito_Click);
            // 
            // bttDesign
            // 
            this.bttDesign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bttDesign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttDesign.FlatAppearance.BorderSize = 0;
            this.bttDesign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttDesign.ForeColor = System.Drawing.Color.White;
            this.bttDesign.Image = global::PIDeffine.Properties.Resources.RegistrarBtont;
            this.bttDesign.Location = new System.Drawing.Point(61, 212);
            this.bttDesign.Name = "bttDesign";
            this.bttDesign.Size = new System.Drawing.Size(156, 36);
            this.bttDesign.TabIndex = 70;
            this.bttDesign.Text = "Diseña tu estilo";
            this.bttDesign.UseVisualStyleBackColor = false;
            this.bttDesign.Click += new System.EventHandler(this.bttDesign_Click);
            // 
            // pcbPerfil
            // 
            this.pcbPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbPerfil.Image = global::PIDeffine.Properties.Resources.Ellipse_2;
            this.pcbPerfil.Location = new System.Drawing.Point(852, 83);
            this.pcbPerfil.Name = "pcbPerfil";
            this.pcbPerfil.Size = new System.Drawing.Size(69, 67);
            this.pcbPerfil.TabIndex = 49;
            this.pcbPerfil.TabStop = false;
            this.pcbPerfil.Click += new System.EventHandler(this.pcbPerfil_Click);
            // 
            // bttFiltrar
            // 
            this.bttFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bttFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttFiltrar.FlatAppearance.BorderSize = 0;
            this.bttFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttFiltrar.ForeColor = System.Drawing.Color.White;
            this.bttFiltrar.Image = global::PIDeffine.Properties.Resources.RegistrarBtont;
            this.bttFiltrar.Location = new System.Drawing.Point(61, 649);
            this.bttFiltrar.Name = "bttFiltrar";
            this.bttFiltrar.Size = new System.Drawing.Size(156, 36);
            this.bttFiltrar.TabIndex = 48;
            this.bttFiltrar.Text = "Filtrar";
            this.bttFiltrar.UseVisualStyleBackColor = false;
            this.bttFiltrar.Click += new System.EventHandler(this.bttFiltrar_Click);
            this.bttFiltrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bttFiltrar_MouseDown);
            this.bttFiltrar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bttFiltrar_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PIDeffine.Properties.Resources.deffinneeHeader;
            this.pictureBox1.Location = new System.Drawing.Point(295, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // pcbspain
            // 
            this.pcbspain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbspain.Image = global::PIDeffine.Properties.Resources.image_removebg_preview__13_;
            this.pcbspain.Location = new System.Drawing.Point(61, 85);
            this.pcbspain.Name = "pcbspain";
            this.pcbspain.Size = new System.Drawing.Size(56, 53);
            this.pcbspain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbspain.TabIndex = 27;
            this.pcbspain.TabStop = false;
            this.pcbspain.Click += new System.EventHandler(this.pcbspain_Click);
            // 
            // pcbingle
            // 
            this.pcbingle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbingle.Image = global::PIDeffine.Properties.Resources.engli1;
            this.pcbingle.Location = new System.Drawing.Point(61, 87);
            this.pcbingle.Name = "pcbingle";
            this.pcbingle.Size = new System.Drawing.Size(56, 52);
            this.pcbingle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbingle.TabIndex = 28;
            this.pcbingle.TabStop = false;
            this.pcbingle.Click += new System.EventHandler(this.pcbingle_Click);
            // 
            // pcbFiltros
            // 
            this.pcbFiltros.Image = global::PIDeffine.Properties.Resources.Group11;
            this.pcbFiltros.Location = new System.Drawing.Point(26, 176);
            this.pcbFiltros.Name = "pcbFiltros";
            this.pcbFiltros.Size = new System.Drawing.Size(238, 606);
            this.pcbFiltros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFiltros.TabIndex = 31;
            this.pcbFiltros.TabStop = false;
            // 
            // pcbPrincipal
            // 
            this.pcbPrincipal.Image = global::PIDeffine.Properties.Resources.FONDOGRISS;
            this.pcbPrincipal.Location = new System.Drawing.Point(26, 170);
            this.pcbPrincipal.Name = "pcbPrincipal";
            this.pcbPrincipal.Size = new System.Drawing.Size(952, 578);
            this.pcbPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPrincipal.TabIndex = 30;
            this.pcbPrincipal.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-5, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1007, 706);
            this.pictureBox2.TabIndex = 56;
            this.pictureBox2.TabStop = false;
            // 
            // btnBorrarFiltros
            // 
            this.btnBorrarFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnBorrarFiltros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarFiltros.FlatAppearance.BorderSize = 0;
            this.btnBorrarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarFiltros.ForeColor = System.Drawing.Color.White;
            this.btnBorrarFiltros.Image = global::PIDeffine.Properties.Resources.RegistrarBtont;
            this.btnBorrarFiltros.Location = new System.Drawing.Point(60, 691);
            this.btnBorrarFiltros.Name = "btnBorrarFiltros";
            this.btnBorrarFiltros.Size = new System.Drawing.Size(156, 36);
            this.btnBorrarFiltros.TabIndex = 73;
            this.btnBorrarFiltros.Text = "Borrar Filtros";
            this.btnBorrarFiltros.UseVisualStyleBackColor = false;
            this.btnBorrarFiltros.Click += new System.EventHandler(this.btnBorrarFiltros_Click);
            // 
            // txtPrecioMin
            // 
            this.txtPrecioMin.Location = new System.Drawing.Point(138, 322);
            this.txtPrecioMin.Name = "txtPrecioMin";
            this.txtPrecioMin.Size = new System.Drawing.Size(100, 30);
            this.txtPrecioMin.TabIndex = 0;
            this.txtPrecioMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioMin_KeyPress);
            // 
            // txtPrecioMax
            // 
            this.txtPrecioMax.Location = new System.Drawing.Point(138, 358);
            this.txtPrecioMax.Name = "txtPrecioMax";
            this.txtPrecioMax.Size = new System.Drawing.Size(100, 30);
            this.txtPrecioMax.TabIndex = 74;
            this.txtPrecioMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioMax_KeyPress);
            // 
            // rdbBandas
            // 
            this.rdbBandas.AutoSize = true;
            this.rdbBandas.Location = new System.Drawing.Point(3, 91);
            this.rdbBandas.Name = "rdbBandas";
            this.rdbBandas.Size = new System.Drawing.Size(192, 27);
            this.rdbBandas.TabIndex = 4;
            this.rdbBandas.Text = "Bandas de musica";
            this.rdbBandas.UseVisualStyleBackColor = true;
            // 
            // rdbSeries
            // 
            this.rdbSeries.AutoSize = true;
            this.rdbSeries.Location = new System.Drawing.Point(3, 122);
            this.rdbSeries.Name = "rdbSeries";
            this.rdbSeries.Size = new System.Drawing.Size(186, 27);
            this.rdbSeries.TabIndex = 5;
            this.rdbSeries.Text = "Series y películas";
            this.rdbSeries.UseVisualStyleBackColor = true;
            // 
            // rdbVideojuegos
            // 
            this.rdbVideojuegos.AutoSize = true;
            this.rdbVideojuegos.Location = new System.Drawing.Point(3, 155);
            this.rdbVideojuegos.Name = "rdbVideojuegos";
            this.rdbVideojuegos.Size = new System.Drawing.Size(138, 27);
            this.rdbVideojuegos.TabIndex = 6;
            this.rdbVideojuegos.Text = "Videojuegos";
            this.rdbVideojuegos.UseVisualStyleBackColor = true;
            // 
            // FrmTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1004, 741);
            this.Controls.Add(this.lblColecciones);
            this.Controls.Add(this.panelColecciones);
            this.Controls.Add(this.txtPrecioMax);
            this.Controls.Add(this.txtPrecioMin);
            this.Controls.Add(this.bttDesign);
            this.Controls.Add(this.btnBorrarFiltros);
            this.Controls.Add(this.pcbCarrito);
            this.Controls.Add(this.panelPrinc);
            this.Controls.Add(this.cmbTalla);
            this.Controls.Add(this.pcbPerfil);
            this.Controls.Add(this.bttFiltrar);
            this.Controls.Add(this.lblContacta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pcbspain);
            this.Controls.Add(this.pcbingle);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.paneldecontrol);
            this.Controls.Add(this.lblMinimo);
            this.Controls.Add(this.lblMaximo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblTalla);
            this.Controls.Add(this.pcbFiltros);
            this.Controls.Add(this.pcbPrincipal);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmTienda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEFFINE - TIENDA DE ROPA";
            this.Load += new System.EventHandler(this.FrmTienda_Load);
            this.paneldecontrol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogOut)).EndInit();
            this.panelColecciones.ResumeLayout(false);
            this.panelColecciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbspain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbingle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFiltros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paneldecontrol;
        private System.Windows.Forms.PictureBox pcbCerrar;
        private System.Windows.Forms.PictureBox pcbMinimizar;
        private System.Windows.Forms.PictureBox pcbLogOut;
        private System.Windows.Forms.PictureBox pcbspain;
        private System.Windows.Forms.PictureBox pcbingle;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.PictureBox pcbPrincipal;
        private System.Windows.Forms.PictureBox pcbFiltros;
        private System.Windows.Forms.Label lblTalla;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblColecciones;
        private System.Windows.Forms.Label lblMaximo;
        private System.Windows.Forms.Label lblMinimo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblContacta;
        private System.Windows.Forms.Button bttFiltrar;
        private System.Windows.Forms.PictureBox pcbPerfil;
        private System.Windows.Forms.ComboBox cmbTalla;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelPrinc;
        private System.Windows.Forms.Panel panelColecciones;
        private System.Windows.Forms.RadioButton rdbPantalones;
        private System.Windows.Forms.RadioButton rdbCamisetas;
        private System.Windows.Forms.RadioButton rdTodo;
        private System.Windows.Forms.Button bttDesign;
        private System.Windows.Forms.PictureBox pcbCarrito;
        private System.Windows.Forms.Button btnBorrarFiltros;
        private System.Windows.Forms.TextBox txtPrecioMin;
        private System.Windows.Forms.TextBox txtPrecioMax;
        private System.Windows.Forms.RadioButton rdbVideojuegos;
        private System.Windows.Forms.RadioButton rdbSeries;
        private System.Windows.Forms.RadioButton rdbBandas;
    }
}