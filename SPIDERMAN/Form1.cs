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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbo_modo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_modo.Items.Add("ESTABILIDAD Y EQUILIBRIO DEL CUERPO");
            cbo_modo.Items.Add("SALTOS DE RESCATE");
        }       

        private void btn_Validacion_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbo_modo.Text))
            {
                bool cbo = (cbo_modo.SelectedItem.ToString() == "ESTABILIDAD Y EQUILIBRIO DEL CUERPO" || cbo_modo.SelectedItem.ToString() == "SALTOS DE RESCATE");
                if (txt_name.Text != "" && cbo)
                {
                    MessageBox.Show("Registro Exitoso", "CONTINUAMOS......", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                    if(cbo_modo.SelectedItem.ToString() == "ESTABILIDAD Y EQUILIBRIO DEL CUERPO")
                    {
                        ESTABILIDAD est = new ESTABILIDAD();
                        est.ShowDialog();
                    }
                    else
                    {
                        SALTOS sal = new SALTOS();
                        sal.ShowDialog();
                    }      
                }
                else
                {
                    MessageBox.Show("llena todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Elige un modo de juego!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
