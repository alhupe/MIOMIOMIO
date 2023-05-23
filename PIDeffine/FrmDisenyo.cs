using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIDeffine
{
    public partial class FrmDisenyo : Form
    {
        public FrmDisenyo()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(paneldecontrol_MouseDown);
            this.MouseMove += new MouseEventHandler(paneldecontrol_MouseMove);
            this.MouseUp += new MouseEventHandler(paneldecontrol_MouseUp);
        }

        private int mouseX = 0, mouseY = 0;
        private bool mouseDown;
        private void FrmDisenyo_Load(object sender, EventArgs e)
        {

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

        private void pcbCerrar_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Form formulario = Application.OpenForms[i];

                formulario.Close();
                formulario.Dispose();
            }
        }

        private void pcbVolver_Click(object sender, EventArgs e)
        {
            FrmTienda frm = new FrmTienda();
            frm.Show();
            this.Hide();
        }

        private void pcbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pcbLogOut_Click(object sender, EventArgs e)
        {
            DialogResult logOut = MessageBox.Show("¿Deseas cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (logOut == DialogResult.Yes)
            {
                FrmInicio frm = new FrmInicio();
                frm.Show();
                this.Hide();
            }
        }

        private void paneldecontrol_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
            mouseDown = true;
        }


        private void DesmarcarColores()
        {
            pcbBlanco.Image = PIDeffine.Properties.Resources.elipseblanca;
            pcbAzul.Image = PIDeffine.Properties.Resources.elipseazul;
            pcbNegro.Image = PIDeffine.Properties.Resources.elipsenegra;
            pcbVerde.Image = PIDeffine.Properties.Resources.elipseverde;
            pcbCamisetaPrinc.BackColor = Color.Black;
        }


        private void DesmarcarCamisetas()
        {
            pcbCamiseta.Image = PIDeffine.Properties.Resources.camisetablancadisenyo;
            pcbCamisetaLarga.Image = PIDeffine.Properties.Resources.camisetalargadisenyo;
            pcbTirantes.Image = PIDeffine.Properties.Resources.camisetatirantesdisenyo;
            pcbSudadera.Image = PIDeffine.Properties.Resources.camisetasudaderadisenyo;
        }
        private void rdbCamiseta_CheckedChanged(object sender, EventArgs e)
        {
            DesmarcarCamisetas();
            pcbCamiseta.Image = PIDeffine.Properties.Resources.camiblancaS;
            if (rdbBlanco.Checked)
            {
                pcbCamisetaPrinc.Image = PIDeffine.Properties.Resources.camiblanca;
                BackColorBlack();
            }
            else if (rdbNegro.Checked)
            {
                pcbCamisetaPrinc.Image = PIDeffine.Properties.Resources.camiseta_roly_dogo_negra_1200Wx1200H_removebg_preview;
                BackColorWhite();
            }
            else if (rdbAzul.Checked)
            {
                pcbCamisetaPrinc.Image = PIDeffine.Properties.Resources.camiseta_m_c_roly_beagle_removebg_preview;
                BackColorBlack();
            }
            else
            {
                pcbCamisetaPrinc.Image = PIDeffine.Properties.Resources.CA6554_20_2_1_removebg_preview;
                BackColorBlack();
            }
        }

        private void rdbLarga_CheckedChanged(object sender, EventArgs e)
        {
            DesmarcarCamisetas();
            pcbCamisetaLarga.Image = PIDeffine.Properties.Resources.camilargaS;
            if (rdbBlanco.Checked)
            {
                pcbCamisetaPrinc.Image = PIDeffine.Properties.Resources.camiblancalarga;
                BackColorBlack();
            }
            else if (rdbNegro.Checked)
            {
                pcbCamisetaPrinc.Image = PIDeffine.Properties.Resources.camilarganegra;
                BackColorWhite();
            }
            else if (rdbAzul.Checked)
            {
                pcbCamisetaPrinc.Image = PIDeffine.Properties.Resources.camilargaazul;
                BackColorBlack();
            }
            else
            {
                pcbCamisetaPrinc.Image = PIDeffine.Properties.Resources.camilargaverde;
                BackColorBlack();
            }
        }

        private void rdbTirant_CheckedChanged(object sender, EventArgs e)
        {
            DesmarcarCamisetas();
            pcbTirantes.Image = PIDeffine.Properties.Resources.CamitirantesS2;
            if (rdbBlanco.Checked)
            {
                pcbCamisetaPrinc.Image = PIDeffine.Properties.Resources.camitirantesblanca;
                BackColorBlack();
            }
            else if (rdbNegro.Checked)
            {
                pcbCamisetaPrinc.Image = PIDeffine.Properties.Resources.caminegratirantes;
                BackColorWhite();
            }
            else if (rdbAzul.Checked)
            {
                pcbCamisetaPrinc.Image = PIDeffine.Properties.Resources.camitirantesazul;
                BackColorBlack();
            }
            else
            {
                pcbCamisetaPrinc.Image = PIDeffine.Properties.Resources.camitirantesverde;
                BackColorBlack();
            }
        }

        private void rdbSuda_CheckedChanged(object sender, EventArgs e)
        {
            DesmarcarCamisetas();
            pcbSudadera.Image = PIDeffine.Properties.Resources.SusdaderaS;
            if (rdbBlanco.Checked)
            {
                pcbCamisetaPrinc.Image = PIDeffine.Properties.Resources.camisudaderablanca;
                BackColorBlack();
            }
            else if (rdbNegro.Checked)
            {
                pcbCamisetaPrinc.Image = PIDeffine.Properties.Resources.caminegrasudadera;
                BackColorWhite();
            }
            else if (rdbAzul.Checked)
            {
                pcbCamisetaPrinc.Image = PIDeffine.Properties.Resources.camiazulsudadera;
                BackColorBlack();
            }
            else
            {
                pcbCamisetaPrinc.Image = PIDeffine.Properties.Resources.camisudaderaverde;
                BackColorBlack();
            }
        }

        private void rdbBlanco_CheckedChanged(object sender, EventArgs e)
        {
            DesmarcarColores();
            pcbBlanco.Image = PIDeffine.Properties.Resources.elipseblancaS;
            if (rdbCamiseta.Checked)
            {
                pcbCamisetaPrinc.Image = PIDeffine.Properties.Resources.camiblanca;
                BackColorBlack();
            }
            else if (rdbLarga.Checked)
            {
                pcbCamisetaPrinc.Image = PIDeffine.Properties.Resources.camiblancalarga;
                BackColorBlack();
            }
            else if (rdbTirant.Checked)
            {
                pcbCamisetaPrinc.Image = PIDeffine.Properties.Resources.camitirantesblanca;
                BackColorBlack();
            }
            else
            {
                pcbCamisetaPrinc.Image = PIDeffine.Properties.Resources.camisudaderablanca;
                BackColorBlack();
            }
        }

        private void rdbNegro_CheckedChanged(object sender, EventArgs e)
        {
            DesmarcarColores();
            pcbNegro.Image = PIDeffine.Properties.Resources.elipsenegraS;
            if (rdbCamiseta.Checked)
            {
                pcbCamisetaPrinc.Image = PIDeffine.Properties.Resources.camiseta_roly_dogo_negra_1200Wx1200H_removebg_preview;
                BackColorWhite();
            }
            else if (rdbLarga.Checked)
            {
                pcbCamisetaPrinc.Image = PIDeffine.Properties.Resources.camilarganegra;
                BackColorWhite();
            }
            else if (rdbTirant.Checked)
            {
                pcbCamisetaPrinc.Image = PIDeffine.Properties.Resources.caminegratirantes;
                BackColorWhite();
            }
            else
            {
                pcbCamisetaPrinc.Image = PIDeffine.Properties.Resources.caminegrasudadera;
                BackColorWhite();
            }
        }

        private void rdbAzul_CheckedChanged(object sender, EventArgs e)
        {
            DesmarcarColores();
            pcbAzul.Image = PIDeffine.Properties.Resources.elipseazulS;
            if (rdbCamiseta.Checked)
            {
                pcbCamisetaPrinc.Image = PIDeffine.Properties.Resources.camiseta_m_c_roly_beagle_removebg_preview;
                BackColorBlack();
            }
            else if (rdbLarga.Checked)
            {
                pcbCamisetaPrinc.Image = PIDeffine.Properties.Resources.camilargaazul;
                BackColorBlack();
            }
            else if (rdbTirant.Checked)
            {
                pcbCamisetaPrinc.Image = PIDeffine.Properties.Resources.camitirantesazul;
                BackColorBlack();
            }
            else
            {
                pcbCamisetaPrinc.Image = PIDeffine.Properties.Resources.camiazulsudadera;
                BackColorBlack();
            }
        }

        private void rdbVerde_CheckedChanged(object sender, EventArgs e)
        {
            DesmarcarColores();
            pcbVerde.Image = PIDeffine.Properties.Resources.elipseverdeS;
            if (rdbCamiseta.Checked)
            {
                pcbCamisetaPrinc.Image = PIDeffine.Properties.Resources.CA6554_20_2_1_removebg_preview;
                BackColorBlack();
            }
            else if (rdbLarga.Checked)
            {
                pcbCamisetaPrinc.Image = PIDeffine.Properties.Resources.camilargaverde;
                BackColorBlack();
            }
            else if (rdbTirant.Checked)
            {
                pcbCamisetaPrinc.Image = PIDeffine.Properties.Resources.camisetatirantesverdebuena;
                BackColorBlack();
            }
            else
            {
                pcbCamisetaPrinc.Image = PIDeffine.Properties.Resources.camisudaderaverde;
                BackColorBlack();
            }
        }
        private void BackColorWhite()
        {
            pcbCamisetaPrinc.BackColor = Color.White;
        }

        private void bttGuardar_Click(object sender, EventArgs e)
        {

        }

        private void pcbCalavera_Click(object sender, EventArgs e)
        {
            HideDisenyo();
            pcbCalaveraGrande.Show();
        }

        private void pcbCorazon_Click(object sender, EventArgs e)
        {
            HideDisenyo();
            pcbCorazonGrande.Show();
        }

        private void pcbWilly_Click(object sender, EventArgs e)
        {
            HideDisenyo();
            pcbWillyGrande.Show();
        }

        private void pcbGato_Click(object sender, EventArgs e)
        {
            HideDisenyo();
            pcbGatoGrande.Show();
        }
        private void BackColorBlack()
        {
            pcbCamisetaPrinc.BackColor = Color.Black;
        }

        private void bttAdjuntar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConBD.Conexion != null)
                {
                    ConBD.AbrirConexion();
                    HideDisenyo();
                    OpenFileDialog cargaImagen = new OpenFileDialog();
                    cargaImagen.InitialDirectory = "C:\\";
                    cargaImagen.Filter = "Archivos de imagen (*.jpeg;*.jpg;*.png)|*.jpeg;*.jpg;*.png";
                    cargaImagen.FilterIndex = 0;
                    if (cargaImagen.ShowDialog() == DialogResult.OK)
                    {
                        pcbimportar.ImageLocation = cargaImagen.FileName;
                        pcbimportar.Show();
                    }
                    else
                    {
                        MessageBox.Show("No se ha seleccionado imagen", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void bttAnyadirTexto_Click(object sender, EventArgs e)
        {
            lbltutextoaqui.Text = txtanyadirtexto.Text;
            lbltutextoaqui.Show();
        }

        private void rdbTxtBlanco_CheckedChanged(object sender, EventArgs e)
        {
            lbltutextoaqui.ForeColor = Color.White;
            lbltutextoaqui.BackColor = Color.Black;
        }

        private void rdbFondoNegro_CheckedChanged(object sender, EventArgs e)
        {
            lbltutextoaqui.BackColor = Color.White;
            lbltutextoaqui.ForeColor = Color.Black;
        }

        private void txtanyadirtexto_TextChanged(object sender, EventArgs e)
        {
            if (txtanyadirtexto.Text == "") lbltutextoaqui.Hide();
        }

        private void HideDisenyo()
        {
            pcbGatoGrande.Hide();
            pcbCalaveraGrande.Hide();
            pcbCorazonGrande.Hide();
            pcbWillyGrande.Hide();
            pcbimportar.Hide();
        }
    }
}
