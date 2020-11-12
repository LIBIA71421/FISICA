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
    public partial class FUERZA_G : Form
    {
        public FUERZA_G()
        {
            InitializeComponent();
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            ESTABILIDAD est = new ESTABILIDAD();
            est.ShowDialog();
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

        private void btn_Calcu_Click(object sender, EventArgs e)
        {
            CALCULADORA est = new CALCULADORA();
            est.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FORMULARIO est = new FORMULARIO();
            est.ShowDialog();
        }

        private void btn_Verificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbo_unidad.Text))
            {
                if (Convert.ToInt16(txt_resp.Text) == 15750 && cbo_unidad.SelectedItem.ToString() == "JOULE[J]")
                {
                    MessageBox.Show("BIEN HECHO SIGAMOS JUGANDO!", "CORRECTO", MessageBoxButtons.OK);
                    this.Hide();
                    ESTABILIDAD est = new ESTABILIDAD();
                    est.ShowDialog();
                }
                else
                {
                    MessageBox.Show(":'( PERDIMOS LO SIENTO ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Elige la Unidad !!!", "OJO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
