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
    public partial class CALCULADORA : Form
    {
        double primero;
        double segundo;
        string operador;

        public CALCULADORA()
        {
            InitializeComponent();
        }
        ClassCalculadora obj = new ClassCalculadora();

        private void btn_igual_Click(object sender, EventArgs e)
        {
            segundo = Convert.ToDouble(txt_entrada.Text);

            double sum , res , divi , mul;
            double csc , sen , cos , cot , tg , sec;
            double r_2 , r_3 , r_n;             
            double pi , ee;
            double p_n , p_2 , p_3;
            double ln, log;
            switch (operador)
            {
                case "+":
                    sum = obj.suma((primero), (segundo));              txt_entrada.Text = sum.ToString();
                    break;
                case "-":
                    res = obj.resta((primero), (segundo));             txt_entrada.Text = res.ToString();
                    break;
                case "/":   
                    divi = obj.div((primero), (segundo));              txt_entrada.Text = divi.ToString();
                    break;
                case "*":
                    mul = obj.Mult((primero), (segundo));              txt_entrada.Text = mul.ToString();
                    break;

                case "ⁿ√":
                    r_n = obj.raiz_n((primero), (segundo)); txt_entrada.Text = r_n.ToString();
                    break;
                case "²√":
                    r_2 = obj.raiz_2(primero);             txt_entrada.Text = r_2.ToString();
                    break;
                case "³√":
                    r_3 = obj.raiz_3(primero); txt_entrada.Text = r_3.ToString();
                    break;

                case "SEN(":
                    sen = obj.sen(primero);              txt_entrada.Text = sen.ToString();
                    break;
                case "CSC(":
                    csc = obj.csc(primero); txt_entrada.Text = csc.ToString();
                    break;
                case "SEC(":
                    sec = obj.sec(primero);              txt_entrada.Text = sec.ToString();
                    break;
                case "COS(":
                    cos = obj.cos(primero);             txt_entrada.Text = cos.ToString();
                    break;
                case "COT(":
                    cot = obj.ctg(primero);              txt_entrada.Text = cot.ToString();
                    break;
                case "TG(":
                    tg = obj.tg(primero);              txt_entrada.Text = tg.ToString();
                    break;

                case "E":
                    ee = obj.e(primero);             txt_entrada.Text = e.ToString();
                    break;

                case "LN(":
                    ln = obj.ln(primero);              txt_entrada.Text = ln.ToString();
                    break;
                case "LOG(":
                    log = obj.log(primero);              txt_entrada.Text = log.ToString();
                    break;

                case "Xⁿ":
                    p_n = obj.pt_n((primero), (segundo));              txt_entrada.Text = p_n.ToString();
                    break;
                case "X²":
                    p_2 = obj.pt_2(primero);                    txt_entrada.Text = p_2.ToString();
                    break;
                case "X³":
                    p_3 = obj.pt_3(primero);              txt_entrada.Text = p_3.ToString();
                    break;

                case "π":
                    pi = obj.pi(primero);              txt_entrada.Text = pi.ToString();
                    break;
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_entrada.Text = txt_entrada.Text + "1";
        }

        private void OK_Click(object sender, EventArgs e)
        {            this.Hide();        }
        private void btn_dec_Click(object sender, EventArgs e)
        {            txt_entrada.Text = txt_entrada.Text + ".";        }

        private void btn_2_Click(object sender, EventArgs e)
        {            txt_entrada.Text = txt_entrada.Text + "2";        }

        private void btn_3_Click(object sender, EventArgs e)
        {            txt_entrada.Text = txt_entrada.Text + "3";        }

        private void btn_4_Click(object sender, EventArgs e)
        {            txt_entrada.Text = txt_entrada.Text + "4";        }

        private void btn_5_Click(object sender, EventArgs e)
        {            txt_entrada.Text = txt_entrada.Text + "5";        }

        private void btn_6_Click(object sender, EventArgs e)
        {            txt_entrada.Text = txt_entrada.Text + "6";        }

        private void btn_7_Click(object sender, EventArgs e)
        {            txt_entrada.Text = txt_entrada.Text + "7";        }

        private void btn_8_Click(object sender, EventArgs e)
        {            txt_entrada.Text = txt_entrada.Text + "8";        }

        private void btn_9_Click(object sender, EventArgs e)
        {            txt_entrada.Text = txt_entrada.Text + "9";        }

        private void btn_0_Click(object sender, EventArgs e)
        {            txt_entrada.Text = txt_entrada.Text + "0";        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(txt_entrada.Text);
            txt_entrada.Clear();
        }

        private void btn_subs_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(txt_entrada.Text);
            txt_entrada.Clear();
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(txt_entrada.Text);
            txt_entrada.Clear();
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(txt_entrada.Text);
            txt_entrada.Clear();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_entrada.Clear();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (txt_entrada.Text.Length == 1)
            {                txt_entrada.Text = "";            }
            else
            {
                txt_entrada.Text = txt_entrada.Text.Substring(0, txt_entrada.Text.Length - 1);
            }
        }

        private void btn_PI_Click(object sender, EventArgs e)
        {
            operador = "π";
            primero = double.Parse(txt_entrada.Text);
            txt_entrada.Clear();
        }

        private void btn_elevado_3_Click(object sender, EventArgs e)
        {
            operador = "X³";
            primero = double.Parse(txt_entrada.Text);
            txt_entrada.Clear();
        }

        private void btn_elevado_2_Click(object sender, EventArgs e)
        {
            operador = "X²";
            primero = double.Parse(txt_entrada.Text);
            txt_entrada.Clear();
        }

        private void btn_elevado_n_Click(object sender, EventArgs e)
        {
            operador = "Xⁿ";
            primero = double.Parse(txt_entrada.Text);
            txt_entrada.Clear();
        }

        private void btn_logaritmo_Click(object sender, EventArgs e)
        {
            operador = "LOG(";
            primero = double.Parse(txt_entrada.Text);
        }

        private void btn_logNatural_Click(object sender, EventArgs e)
        {
            operador = "LN(";
            primero = double.Parse(txt_entrada.Text);
        }

        private void btn_e_Click(object sender, EventArgs e)
        {
            operador = "E";
            primero = double.Parse(txt_entrada.Text);
        }

        private void btn_tangente_Click(object sender, EventArgs e)
        {
            operador = "TG(";
            primero = double.Parse(txt_entrada.Text);
        }

        private void btn_cotangente_Click(object sender, EventArgs e)
        {
            operador = "COT(";
            primero = double.Parse(txt_entrada.Text);
        }

        private void btn_Raiz_ene_Click(object sender, EventArgs e)
        {
            operador = "ⁿ√";
            primero = double.Parse(txt_entrada.Text);
            txt_entrada.Clear();
        }

        private void btn_coseno_Click(object sender, EventArgs e)
        {
            operador = "COS(";
            primero = double.Parse(txt_entrada.Text);
        }

        private void btn_secante_Click(object sender, EventArgs e)
        {
            operador = "SEC(";
            primero = double.Parse(txt_entrada.Text);
        }

        private void btn_R_cubica_Click(object sender, EventArgs e)
        {
            operador = "³√";
            primero = double.Parse(txt_entrada.Text);
            txt_entrada.Clear();
        }

        private void btn_seno_Click(object sender, EventArgs e)
        {
            operador = "SEN(";
            primero = double.Parse(txt_entrada.Text);
        }

        private void btn_R_cuadrado_Click(object sender, EventArgs e)
        {
            operador = "²√";
            primero = double.Parse(txt_entrada.Text);
            txt_entrada.Clear();
        }

        private void btn_cosecante_Click(object sender, EventArgs e)
        {
            operador = "CSC(";
            primero = double.Parse(txt_entrada.Text);
        }
    }
    }
