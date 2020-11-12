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
    public partial class SALTOS : Form
    {
        public SALTOS()
        {
            InitializeComponent();
        }

        private void btn_balance_C_Click(object sender, EventArgs e)
        {
            this.Hide();
            LIANA cuerda = new LIANA();
            cuerda.ShowDialog();
        }

        private void btn_Picada_Click(object sender, EventArgs e)
        {
            this.Hide();
            SALTO_PICADA Pic = new SALTO_PICADA();
            Pic.ShowDialog();
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
            LIANA cuerda = new LIANA();
            cuerda.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SALTO_PICADA Pic = new SALTO_PICADA();
            Pic.ShowDialog();
        }
    }
}
