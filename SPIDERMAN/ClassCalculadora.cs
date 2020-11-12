using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPIDERMAN
{
    class ClassCalculadora
    {
        public double suma(double N1, double N2)
        {
            double S;
            S = N1 + N2;
            return S;
        }
        public double resta(double N1, double N2)
        {
            double R;
            R = N1 - N2;
            return R;
        }
        public double Mult(double N1, double N2)
        {
            double M;
            M = N1 * N2;
            return M;
        }
        public double div(double N1, double N2)
        {
            double D;
            D = N1 / N2;
            return D;
        }
        public double sen(double N1)
        {
            double s;
            s = Math.Sin(N1);
            return s;
        }
        public double cos(double N1)
        {
            double c;
            c = Math.Cos(N1);
            return c;
        }
        public double tg(double N1)
        {
            double t;
            t = Math.Tan(N1);
            return t;
        }
        public double ctg(double N1)
        {
            double ct;
            ct = Math.Tanh(N1);
            return ct;
        }
        public double csc(double N1)
        {
            double csc;
            csc = Math.Sinh(N1);
            return csc;
        }
        public double sec(double N1)
        {
            double sec;
            sec = Math.Cosh(N1);
            return sec;
        }
        public double log(double N1)
        {
            double log;
            log = Math.Log(N1);
            return log;
        }
        public double ln(double N1)
        {
            double ln;
            ln = Math.Log10(N1);
            return ln;
        }
        public double pt_n(double N1, double ene)
        {
            double pt_n;
            pt_n = Math.Pow(N1,ene);
            return pt_n;
        }
        public double pt_2(double N1)
        {
            double pt_2;
            pt_2 = Math.Pow(N1,2);
            return pt_2;
        }
        public double pt_3(double N1)
        {
            double pt_3;
            pt_3 = Math.Pow(N1, 3);
            return pt_3;
        }
        public double raiz_n(double N1, double N2)
        {
            double raiz_n;
            raiz_n = Math.Pow(N1, N2);
            return raiz_n;
        }
        public double raiz_2(double N1)
        {
            double raiz_2;
            raiz_2 = Math.Pow(N1, 0.5);
            return raiz_2;
        }
        public double raiz_3(double N1)
        {
            double raiz_3;
            raiz_3 = Math.Pow(N1, 0.33333);
            return raiz_3;
        }
        public double pi(double N1)
        {
            double pi;
            pi = N1 * 3.14159265359;
            return pi;
        }
        public double e(double N1)
        {
            double e;
            e = N1 * 2.71828182846;
            return e;
        }
    }
}
