using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPIDERMAN
{
    public partial class ESTABILIDAD : Form
    {
        public ESTABILIDAD()
        {
            InitializeComponent();
        }

        private void btn_Trepar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TREPAR trep = new TREPAR();
            trep.ShowDialog();
        }

        private void btn_Fuerza_C_Click(object sender, EventArgs e)
        {
            this.Hide();
            FUERZA_C cuerd = new FUERZA_C();
            cuerd.ShowDialog();
        }

        private void btn_Fuerza_G_Click(object sender, EventArgs e)
        {
            this.Hide();
            FUERZA_G grav = new FUERZA_G();
            grav.ShowDialog();
        }

        private void btn_SALIR_Click(object sender, EventArgs e)
        {
            const string message = "seguro que quiere salir ?";
            const string til = "PREGUNTA";

            var mensaje = MessageBox.Show(message, til, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (mensaje == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TREPAR trep = new TREPAR();
            trep.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FUERZA_C cuerd = new FUERZA_C();
            cuerd.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FUERZA_G grav = new FUERZA_G();
            grav.ShowDialog();
        }
    }
}
