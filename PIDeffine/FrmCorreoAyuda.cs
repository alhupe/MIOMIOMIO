using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIDeffine
{
    public partial class FrmCorreoAyuda : Form
    {
        public FrmCorreoAyuda()
        {
            InitializeComponent();
        }

        private void bttEnviar_Click(object sender, EventArgs e)
        {
            try
            {

                if (ConBD.Conexion != null)
                {
                    ConBD.AbrirConexion();
                    string correo = txtCorreo.Text;
                    if (correo != "")
                    {
                        if (Cliente.ComprobarExistencia(correo))
                        {

                            try
                            {
                                string contraseña = Cliente.DevolverClave(correo);
                                MailMessage email = new MailMessage();
                                email.To.Add(new MailAddress("deffinepi@gmail.com"));
                                email.From = new MailAddress(correo);
                                email.Subject = txtAsunto.Text;
                                string mensaje = "El Usuario con correo " + txtCorreo.Text + " adjunta el siguiente problema:\n";
                                email.Body = mensaje + txtProblema.Text;
                                email.IsBodyHtml = true;
                                email.Priority = MailPriority.Normal;

                                SmtpClient smtp = new SmtpClient();
                                smtp.Host = "smtp.gmail.com";
                                smtp.Port = 587;
                                smtp.EnableSsl = true;
                                smtp.UseDefaultCredentials = false;
                                smtp.Credentials = new NetworkCredential("deffinepi@gmail.com", "kzjiwbnktbhwtmww");


                                smtp.Send(email);
                                email.Dispose();
                                MessageBox.Show("Comprueba tu buzon de entrada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error al mandar el correo: " + ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El correo indicado no existe en la base de datos, asegurate de estar registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Rellena el campo de correo con el correo electronico del que deseas recuperar la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");

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

        private void pcbVolver_Click(object sender, EventArgs e)
        {
            FrmInicio frmInicio = new FrmInicio();
            frmInicio.Show();
            this.Close();
        }
    }
}
