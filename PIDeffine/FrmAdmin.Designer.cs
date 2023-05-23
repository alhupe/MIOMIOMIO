
namespace PIDeffine
{
    partial class FrmAdmin
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.grbProducto = new System.Windows.Forms.GroupBox();
            this.pcbFotoCamiseta = new System.Windows.Forms.PictureBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbTalla = new System.Windows.Forms.ComboBox();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.bttAdjuntar = new System.Windows.Forms.Button();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblTalla = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.grbUsuario = new System.Windows.Forms.GroupBox();
            this.txtConfContra = new System.Windows.Forms.TextBox();
            this.lblConfContra = new System.Windows.Forms.Label();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.bttInsertarProd = new System.Windows.Forms.Button();
            this.bttEliminarProd = new System.Windows.Forms.Button();
            this.bttInsertarUser = new System.Windows.Forms.Button();
            this.bttEliminarUser = new System.Windows.Forms.Button();
            this.bttVolver = new System.Windows.Forms.Button();
            this.bttSalir = new System.Windows.Forms.Button();
            this.txtIdProd = new System.Windows.Forms.TextBox();
            this.grbProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoCamiseta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            this.grbUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(10, 46);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(152, 28);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // grbProducto
            // 
            this.grbProducto.Controls.Add(this.pcbFotoCamiseta);
            this.grbProducto.Controls.Add(this.cmbGenero);
            this.grbProducto.Controls.Add(this.cmbColor);
            this.grbProducto.Controls.Add(this.cmbTalla);
            this.grbProducto.Controls.Add(this.nudStock);
            this.grbProducto.Controls.Add(this.bttAdjuntar);
            this.grbProducto.Controls.Add(this.nudPrecio);
            this.grbProducto.Controls.Add(this.txtDescripcion);
            this.grbProducto.Controls.Add(this.lblPrecio);
            this.grbProducto.Controls.Add(this.lblTalla);
            this.grbProducto.Controls.Add(this.lblColor);
            this.grbProducto.Controls.Add(this.lblGenero);
            this.grbProducto.Controls.Add(this.lblImagen);
            this.grbProducto.Controls.Add(this.lblStock);
            this.grbProducto.Controls.Add(this.lblDescripcion);
            this.grbProducto.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProducto.Location = new System.Drawing.Point(16, 72);
            this.grbProducto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grbProducto.Name = "grbProducto";
            this.grbProducto.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grbProducto.Size = new System.Drawing.Size(626, 476);
            this.grbProducto.TabIndex = 1;
            this.grbProducto.TabStop = false;
            this.grbProducto.Text = "Producto";
            // 
            // pcbFotoCamiseta
            // 
            this.pcbFotoCamiseta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbFotoCamiseta.Location = new System.Drawing.Point(490, 337);
            this.pcbFotoCamiseta.Name = "pcbFotoCamiseta";
            this.pcbFotoCamiseta.Size = new System.Drawing.Size(128, 132);
            this.pcbFotoCamiseta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFotoCamiseta.TabIndex = 12;
            this.pcbFotoCamiseta.TabStop = false;
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.Items.AddRange(new object[] {
            "Unisex",
            "Masculino",
            "Femenino"});
            this.cmbGenero.Location = new System.Drawing.Point(256, 337);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(193, 36);
            this.cmbGenero.TabIndex = 11;
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.Items.AddRange(new object[] {
            "Negro",
            "Blanco",
            "Azul",
            "Verde",
            "Gris",
            "Rosa",
            "Multi"});
            this.cmbColor.Location = new System.Drawing.Point(256, 279);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(193, 36);
            this.cmbColor.TabIndex = 10;
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
            this.cmbTalla.Location = new System.Drawing.Point(256, 219);
            this.cmbTalla.Name = "cmbTalla";
            this.cmbTalla.Size = new System.Drawing.Size(193, 36);
            this.cmbTalla.TabIndex = 2;
            // 
            // nudStock
            // 
            this.nudStock.Location = new System.Drawing.Point(329, 102);
            this.nudStock.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(120, 36);
            this.nudStock.TabIndex = 9;
            this.nudStock.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // bttAdjuntar
            // 
            this.bttAdjuntar.Location = new System.Drawing.Point(309, 395);
            this.bttAdjuntar.Name = "bttAdjuntar";
            this.bttAdjuntar.Size = new System.Drawing.Size(140, 74);
            this.bttAdjuntar.TabIndex = 8;
            this.bttAdjuntar.Text = "Adjuntar Imagen";
            this.bttAdjuntar.UseVisualStyleBackColor = true;
            this.bttAdjuntar.Click += new System.EventHandler(this.bttAdjuntar_Click);
            // 
            // nudPrecio
            // 
            this.nudPrecio.Location = new System.Drawing.Point(329, 160);
            this.nudPrecio.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(120, 36);
            this.nudPrecio.TabIndex = 7;
            this.nudPrecio.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(207, 46);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(242, 36);
            this.txtDescripcion.TabIndex = 6;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(70, 162);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(91, 28);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblTalla
            // 
            this.lblTalla.AutoSize = true;
            this.lblTalla.Location = new System.Drawing.Point(92, 227);
            this.lblTalla.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTalla.Name = "lblTalla";
            this.lblTalla.Size = new System.Drawing.Size(70, 28);
            this.lblTalla.TabIndex = 4;
            this.lblTalla.Text = "Talla:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(81, 282);
            this.lblColor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(79, 28);
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = "Color:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(58, 345);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(102, 28);
            this.lblGenero.TabIndex = 2;
            this.lblGenero.Text = "Género:";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(58, 405);
            this.lblImagen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(103, 28);
            this.lblImagen.TabIndex = 2;
            this.lblImagen.Text = "Imágen:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(78, 104);
            this.lblStock.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(83, 28);
            this.lblStock.TabIndex = 1;
            this.lblStock.Text = "Stock:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 157);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 215);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 398);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Administrador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 279);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Correo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(239, 154);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(174, 36);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(239, 212);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(215, 36);
            this.txtApellidos.TabIndex = 12;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(239, 96);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(215, 36);
            this.txtCorreo.TabIndex = 13;
            // 
            // grbUsuario
            // 
            this.grbUsuario.Controls.Add(this.txtConfContra);
            this.grbUsuario.Controls.Add(this.lblConfContra);
            this.grbUsuario.Controls.Add(this.chkAdmin);
            this.grbUsuario.Controls.Add(this.txtContra);
            this.grbUsuario.Controls.Add(this.txtCorreo);
            this.grbUsuario.Controls.Add(this.txtApellidos);
            this.grbUsuario.Controls.Add(this.txtNombre);
            this.grbUsuario.Controls.Add(this.label1);
            this.grbUsuario.Controls.Add(this.label2);
            this.grbUsuario.Controls.Add(this.label3);
            this.grbUsuario.Controls.Add(this.label6);
            this.grbUsuario.Controls.Add(this.label7);
            this.grbUsuario.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbUsuario.Location = new System.Drawing.Point(705, 72);
            this.grbUsuario.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grbUsuario.Name = "grbUsuario";
            this.grbUsuario.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grbUsuario.Size = new System.Drawing.Size(498, 476);
            this.grbUsuario.TabIndex = 13;
            this.grbUsuario.TabStop = false;
            this.grbUsuario.Text = "Usuario";
            // 
            // txtConfContra
            // 
            this.txtConfContra.Location = new System.Drawing.Point(239, 342);
            this.txtConfContra.Name = "txtConfContra";
            this.txtConfContra.Size = new System.Drawing.Size(215, 36);
            this.txtConfContra.TabIndex = 17;
            // 
            // lblConfContra
            // 
            this.lblConfContra.AutoSize = true;
            this.lblConfContra.Location = new System.Drawing.Point(44, 345);
            this.lblConfContra.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblConfContra.Name = "lblConfContra";
            this.lblConfContra.Size = new System.Drawing.Size(149, 28);
            this.lblConfContra.TabIndex = 16;
            this.lblConfContra.Text = "Contraseña:";
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.Location = new System.Drawing.Point(239, 405);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(18, 17);
            this.chkAdmin.TabIndex = 15;
            this.chkAdmin.UseVisualStyleBackColor = true;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(239, 276);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(215, 36);
            this.txtContra.TabIndex = 14;
            // 
            // bttInsertarProd
            // 
            this.bttInsertarProd.Location = new System.Drawing.Point(16, 561);
            this.bttInsertarProd.Name = "bttInsertarProd";
            this.bttInsertarProd.Size = new System.Drawing.Size(257, 39);
            this.bttInsertarProd.TabIndex = 13;
            this.bttInsertarProd.Text = "Insertar Producto";
            this.bttInsertarProd.UseVisualStyleBackColor = true;
            this.bttInsertarProd.Click += new System.EventHandler(this.bttInsertarProd_Click);
            // 
            // bttEliminarProd
            // 
            this.bttEliminarProd.Location = new System.Drawing.Point(385, 569);
            this.bttEliminarProd.Name = "bttEliminarProd";
            this.bttEliminarProd.Size = new System.Drawing.Size(257, 38);
            this.bttEliminarProd.TabIndex = 14;
            this.bttEliminarProd.Text = "Eliminar Productos";
            this.bttEliminarProd.UseVisualStyleBackColor = true;
            this.bttEliminarProd.Click += new System.EventHandler(this.bttEliminarProd_Click);
            // 
            // bttInsertarUser
            // 
            this.bttInsertarUser.Location = new System.Drawing.Point(705, 561);
            this.bttInsertarUser.Name = "bttInsertarUser";
            this.bttInsertarUser.Size = new System.Drawing.Size(257, 38);
            this.bttInsertarUser.TabIndex = 15;
            this.bttInsertarUser.Text = "Insertar Usuario";
            this.bttInsertarUser.UseVisualStyleBackColor = true;
            this.bttInsertarUser.Click += new System.EventHandler(this.bttInsertarUser_Click);
            // 
            // bttEliminarUser
            // 
            this.bttEliminarUser.Location = new System.Drawing.Point(985, 561);
            this.bttEliminarUser.Name = "bttEliminarUser";
            this.bttEliminarUser.Size = new System.Drawing.Size(218, 38);
            this.bttEliminarUser.TabIndex = 16;
            this.bttEliminarUser.Text = "Eliminar Usuario";
            this.bttEliminarUser.UseVisualStyleBackColor = true;
            this.bttEliminarUser.Click += new System.EventHandler(this.bttEliminarUser_Click);
            // 
            // bttVolver
            // 
            this.bttVolver.Location = new System.Drawing.Point(16, 12);
            this.bttVolver.Name = "bttVolver";
            this.bttVolver.Size = new System.Drawing.Size(129, 39);
            this.bttVolver.TabIndex = 17;
            this.bttVolver.Text = "Volver";
            this.bttVolver.UseVisualStyleBackColor = true;
            this.bttVolver.Click += new System.EventHandler(this.bttVolver_Click);
            // 
            // bttSalir
            // 
            this.bttSalir.Location = new System.Drawing.Point(1208, 12);
            this.bttSalir.Name = "bttSalir";
            this.bttSalir.Size = new System.Drawing.Size(129, 39);
            this.bttSalir.TabIndex = 18;
            this.bttSalir.Text = "Salir";
            this.bttSalir.UseVisualStyleBackColor = true;
            this.bttSalir.Click += new System.EventHandler(this.bttSalir_Click);
            // 
            // txtIdProd
            // 
            this.txtIdProd.Location = new System.Drawing.Point(1134, 126);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.Size = new System.Drawing.Size(174, 30);
            this.txtIdProd.TabIndex = 6;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 647);
            this.ControlBox = false;
            this.Controls.Add(this.bttSalir);
            this.Controls.Add(this.bttVolver);
            this.Controls.Add(this.bttEliminarUser);
            this.Controls.Add(this.bttInsertarUser);
            this.Controls.Add(this.bttEliminarProd);
            this.Controls.Add(this.bttInsertarProd);
            this.Controls.Add(this.txtIdProd);
            this.Controls.Add(this.grbUsuario);
            this.Controls.Add(this.grbProducto);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdmin";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.grbProducto.ResumeLayout(false);
            this.grbProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoCamiseta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            this.grbUsuario.ResumeLayout(false);
            this.grbUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.GroupBox grbProducto;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.Button bttAdjuntar;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblTalla;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbTalla;
        private System.Windows.Forms.PictureBox pcbFotoCamiseta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.GroupBox grbUsuario;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Button bttInsertarProd;
        private System.Windows.Forms.Button bttEliminarProd;
        private System.Windows.Forms.Button bttInsertarUser;
        private System.Windows.Forms.Button bttEliminarUser;
        private System.Windows.Forms.TextBox txtConfContra;
        private System.Windows.Forms.Label lblConfContra;
        private System.Windows.Forms.Button bttVolver;
        private System.Windows.Forms.Button bttSalir;
        private System.Windows.Forms.TextBox txtIdProd;
    }
}