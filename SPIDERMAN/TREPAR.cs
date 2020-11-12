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
    public partial class TREPAR : Form
    {
        public TREPAR()
        {
            InitializeComponent();
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
            ESTABILIDAD est = new ESTABILIDAD();
            est.ShowDialog();
        }

        //private void btn_reproducir_Click(object sender, EventArgs e)
        //{
        //    openFileDialog.ShowDialog();
        //    axWindowsMediaPlayer1.URL = openFileDialog.FileName;
        //}

        private void btn_Calcu_Click(object sender, EventArgs e)
        {
            CALCULADORA est = new CALCULADORA();
            est.ShowDialog();//bueno ahora dejeme trabajar XD
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            FORMULARIO est = new FORMULARIO();
            est.ShowDialog();
        }

        private void btn_Verificar_Click(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(cbo_unidad_picada.Text))
            //{
            //    if (Convert.ToDouble(txt_resp.Text) == 1826.79 && cbo_unidad_picada.SelectedItem.ToString() == "METROS[m]")
            //    {
            //        MessageBox.Show("BIEN HECHO SIGAMOS JUGANDO!", "CORRECTO", MessageBoxButtons.OK);
            //        this.Hide();
            //        SALTOS est = new SALTOS();
            //        est.ShowDialog();
            //    }
            //    else
            //    { MessageBox.Show(":'( PERDIMOS LO SIENTO ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            //}
            //else
            //{ MessageBox.Show("Elige la Unidad !!!", "OJO", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
