﻿using System;
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
    public partial class SALTO_PICADA : Form
    {
        public SALTO_PICADA()
        {
            InitializeComponent();
            cbo_unidad_picada.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_unidad_picada.Items.Add("METRO POR SEGUNDO[m/s]");
            cbo_unidad_picada.Items.Add("METROS[m]");
            cbo_unidad_picada.Items.Add("METRO POR SEGUNDO AL CUADRADO[m/s²]");
        }
        private void btn_Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            SALTOS est = new SALTOS();
            est.ShowDialog();
        }
        private void btn_SALIR_Click(object sender, EventArgs e)
        {
            const string message = "seguro que quiere salir ?";
            const string til = "PREGUNTA";
            var mensaje = MessageBox.Show(message, til, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (mensaje == DialogResult.Yes)
            {                Application.Exit();            }
        }
        private void btn_Verificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbo_unidad_picada.Text))
            {
                if (Convert.ToDouble(txt_resp.Text) == 1826.79 && cbo_unidad_picada.SelectedItem.ToString() == "METROS[m]")
                {
                    MessageBox.Show("BIEN HECHO SIGAMOS JUGANDO!", "CORRECTO", MessageBoxButtons.OK);
                    this.Hide();
                    SALTOS est = new SALTOS();
                    est.ShowDialog();
                }
                else
                {    MessageBox.Show(":'( PERDIMOS LO SIENTO ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);                }
            }
            else
            {    MessageBox.Show("Elige la Unidad !!!", "OJO", MessageBoxButtons.OK, MessageBoxIcon.Error);            }
        }
        private void ayuda_Click(object sender, EventArgs e)
        {
            FORMULARIO est = new FORMULARIO();
            est.ShowDialog();
        }
    }
}