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
    public partial class LIANA : Form
    {
        public LIANA()
        {
            InitializeComponent();
            cbo_unidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_unidad.Items.Add("JOULE[J]");
            cbo_unidad.Items.Add("METROS[m]");
            cbo_unidad.Items.Add("JOULE POR KELVIN[J/K]");

        }
        private void btn_Calcu_Click(object sender, EventArgs e)
        {
            CALCULADORA est = new CALCULADORA();
            est.ShowDialog();
        }
        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            FORMULARIO est = new FORMULARIO();
            est.ShowDialog();
        }
        private void btn_Verificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbo_unidad.Text))
            {
                if (Convert.ToDouble(txt_resp.Text) == -4800 && cbo_unidad.SelectedItem.ToString() == "JOULE[J]")
                {
                    MessageBox.Show("BIEN HECHO SIGAMOS JUGANDO!", "CORRECTO", MessageBoxButtons.OK);
                    this.Hide();
                    SALTOS est = new SALTOS();
                    est.ShowDialog();
                }
                else
                { MessageBox.Show(":'( PERDIMOS LO SIENTO ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            { MessageBox.Show("Elige la Unidad !!!", "OJO", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btn_SALIR_Click_1(object sender, EventArgs e)
        {
            const string message = "seguro que quiere salir ?";
            const string til = "PREGUNTA";

            var mensaje = MessageBox.Show(message, til, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (mensaje == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Atras_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SALTOS menu = new SALTOS();
            menu.ShowDialog();
        }
    }
}
