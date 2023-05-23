using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIDeffine.RecursosLocalizables;

namespace PIDeffine
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(paneldecontrol_MouseDown);
            this.MouseMove += new MouseEventHandler(paneldecontrol_MouseMove);
            this.MouseUp += new MouseEventHandler(paneldecontrol_MouseUp);
        }
        private int mouseX = 0, mouseY = 0;
        private bool mouseDown;

        private void AplicarIdioma()
        {
            lblApellidos.Text = StringRecursos.Apellidos;
            lblConfirmContra.Text = StringRecursos.ConfirmContra;
            lblContra.Text = StringRecursos.Contra;
            lblCorreo.Text = StringRecursos.Correo;
            lblDatos.Text = StringRecursos.Datos;
            lblDatosPers.Text = StringRecursos.DatosPers;
            lblIdioma.Text = StringRecursos.Idioma;
            lblNombre.Text = StringRecursos.Nombre;
            bttRegistrarse.Text = StringRecursos.Registrarse;
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void bttRegistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConBD.Conexion != null)
                {
                    ConBD.AbrirConexion();
                    string correo = txtCorreo.Text;
                    string nombre = txtNombre.Text;
                    string apellidos = txtApellidos.Text;
                    string clave = txtContra.Text;
                    string confClave = txtConfirmContra.Text;
                    bool admin = false;

                    if (correo != "" && nombre != "" && apellidos != "" && clave != "" && confClave != "")
                    {
                        if (confClave == clave)
                        {
                            if (Cliente.ComprobarExistencia(correo))
                            {
                                MessageBox.Show("Ya existe un usuario con ese correo");
                            }
                            else
                            {
                                Cliente.AgregarCliente(nombre, apellidos, clave, correo, admin);
                                MessageBox.Show("Cliente registado");
                                txtCorreo.Text = "";
                                txtNombre.Text = "";
                                txtApellidos.Text = "";
                                txtContra.Text = "";
                                txtConfirmContra.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("El campo confirmar contraseña y contraseña deben contener la misma contraseña");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Todos los campos son obligatorios");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                ConBD.CerrarConexion();
            }
           
        }

        private void pcbOjoAbierto_Click(object sender, EventArgs e)
        {
            pcbOjoAbierto.Hide();
            pcbOjoCerrado.Show();
            txtContra.PasswordChar = '\0';
        }

        private void pcbOjoCerrado_Click(object sender, EventArgs e)
        {
            pcbOjoCerrado.Hide();
            pcbOjoAbierto.Show();
            txtContra.PasswordChar = '●';
        }

        private void pcbOjoAbierto2_Click(object sender, EventArgs e)
        {
            pcbOjoAbierto2.Hide();
            pcbOjoCerrado2.Show();
            txtConfirmContra.PasswordChar = '\0';

        }

        private void pcbOjoCerrado2_Click(object sender, EventArgs e)
        {
            pcbOjoCerrado2.Hide();
            pcbOjoAbierto2.Show();
            txtConfirmContra.PasswordChar = '●';
        }

        private void pcbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void paneldecontrol_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;

        }

        private void paneldecontrol_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int newX = this.Left + (e.X - mouseX);
                int newY = this.Top + (e.Y - mouseY);
                this.Location = new Point(newX, newY);
            }
        }

        private void paneldecontrol_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
            mouseDown = true;
        }


        private void pcbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblConfirmContra_Click(object sender, EventArgs e)
        {

        }

        private void panelRegistro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IdiomaIngles()
        {
            string cultura = "EN-GB";
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura);
            AplicarIdioma();
        }
        private void IdiomaSpanish()
        {
            string cultura = "ES-ES";
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura);
            AplicarIdioma();
        }

        private void pcbspain_Click(object sender, EventArgs e)
        {
            IdiomaIngles();
            pcbspain.Hide();
            pcbingle.Show();
        }

        private void pcbingle_Click(object sender, EventArgs e)
        {
            IdiomaSpanish();
            pcbingle.Hide();
            pcbspain.Show();
        }

        private void pcbVolver_Click(object sender, EventArgs e)
        {
            FrmInicio inicio = new FrmInicio();
            inicio.Show();
            this.Close();
        }
    }
}
