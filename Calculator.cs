using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using SharpUpdate;

namespace Calculadora_da_TrivialSoft
{
    public partial class Form1 : Form, ISharpUpdatable
    {
        private SharpUpdater updater;

        bool inicio = true;
        double primero;
        double segundo;
        double resultado;
        string operador;

        public Form1()
        {
            InitializeComponent();

            this.flatLabel3.Text = "Versão: " + this.ApplicationAssembly.GetName().Version.ToString();
            updater = new SharpUpdater(this);

            updater.DoUpdate();
        }

        Lessons.ClsOperaciones obj5 = new Lessons.ClsOperaciones();

        Lessons.ClsSuma obj = new Lessons.ClsSuma();
        Lessons.ClsResta obj2 = new Lessons.ClsResta();
        Lessons.ClsMultiplicacion obj3 = new Lessons.ClsMultiplicacion();
        Lessons.ClsDivision obj4 = new Lessons.ClsDivision();

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(tbxScreen.Text);

            double Sum;
            double Res;
            double Mul;
            double Div;

            switch (operador)
            {
                case "+":
                    Sum = obj5.Suma((primero), (segundo));
                    tbxPrevio.Text = tbxPrevio.Text + tbxScreen.Text;
                    tbxScreen.Text = Sum.ToString();
                    break;
                case "-":
                    Res = obj5.Resta((primero), (segundo));
                    tbxPrevio.Text = tbxPrevio.Text + tbxScreen.Text;
                    tbxScreen.Text = Res.ToString();
                    break;
                case "*":
                    Mul = obj5.Multiplicacion((primero), (segundo));
                    tbxPrevio.Text = tbxPrevio.Text + tbxScreen.Text;
                    tbxScreen.Text = Mul.ToString();
                    break;
                case "/":
                    Div = obj5.Division((primero), (segundo));
                    tbxPrevio.Text = tbxPrevio.Text + tbxScreen.Text;
                    tbxScreen.Text = Div.ToString();
                    break;
            }
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                tbxScreen.Text = "";
                tbxScreen.Text = "1";
                inicio = false;
            }
            else
            {
                tbxScreen.Text = tbxScreen.Text + "1";
                inicio = false;
            }
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                tbxScreen.Text = "";
                tbxScreen.Text = "2";
                inicio = false;
            }
            else
            {
                tbxScreen.Text = tbxScreen.Text + "2";
                inicio = false;
            }
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                tbxScreen.Text = "";
                tbxScreen.Text = "3";
                inicio = false;
            }
            else
            {
                tbxScreen.Text = tbxScreen.Text + "3";
                inicio = false;
            }
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                tbxScreen.Text = "";
                tbxScreen.Text = "4";
                inicio = false;
            }
            else
            {
                tbxScreen.Text = tbxScreen.Text + "4";
                inicio = false;
            }
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                tbxScreen.Text = "";
                tbxScreen.Text = "5";
                inicio = false;
            }
            else
            {
                tbxScreen.Text = tbxScreen.Text + "5";
                inicio = false;
            }
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                tbxScreen.Text = "";
                tbxScreen.Text = "6";
                inicio = false;
            }
            else
            {
                tbxScreen.Text = tbxScreen.Text + "6";
                inicio = false;
            }
        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                tbxScreen.Text = "";
                tbxScreen.Text = "7";
                inicio = false;
            }
            else
            {
                tbxScreen.Text = tbxScreen.Text + "7";
                inicio = false;
            }
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                tbxScreen.Text = "";
                tbxScreen.Text = "8";
                inicio = false;
            }
            else
            {
                tbxScreen.Text = tbxScreen.Text + "8";
                inicio = false;
            }
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            if (inicio == true)
            {
                tbxScreen.Text = "";
                tbxScreen.Text = "9";
                inicio = false;
            }
            else
            {
                tbxScreen.Text = tbxScreen.Text + "9";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            primero = double.Parse(tbxScreen.Text);
            resultado = primero;
            tbxPrevio.Text = "log (" + tbxPrevio.Text + tbxScreen.Text + ")";
            tbxScreen.Text = Math.Log(primero).ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            primero = double.Parse(tbxScreen.Text);
            resultado = primero;
            tbxPrevio.Text = "exp (" + tbxPrevio.Text + tbxScreen.Text + ")";
            tbxScreen.Text = Math.Exp(primero).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            primero = double.Parse(tbxScreen.Text);
            resultado = primero;
            tbxPrevio.Text = "tan (" + tbxPrevio.Text + tbxScreen.Text + ")";
            tbxScreen.Text = Math.Tan(primero).ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            primero = double.Parse(tbxScreen.Text);
            resultado = primero;
            tbxPrevio.Text = "tanh (" + tbxPrevio.Text + tbxScreen.Text + ")";
            tbxScreen.Text = Math.Tanh(primero).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            primero = double.Parse(tbxScreen.Text);
            resultado = primero;
            tbxPrevio.Text = "sin (" + tbxPrevio.Text + tbxScreen.Text + ")";
            tbxScreen.Text = Math.Sin(primero).ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            primero = double.Parse(tbxScreen.Text);
            resultado = primero;
            tbxPrevio.Text = "sinh (" + tbxPrevio.Text + tbxScreen.Text + ")";
            tbxScreen.Text = Math.Sinh(primero).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            primero = double.Parse(tbxScreen.Text);
            resultado = primero;
            tbxPrevio.Text = "cos (" + tbxPrevio.Text + tbxScreen.Text + ")";
            tbxScreen.Text = Math.Cos(primero).ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            primero = double.Parse(tbxScreen.Text);
            resultado = primero;
            tbxPrevio.Text = "cosh (" + tbxPrevio.Text + tbxScreen.Text + ")";
            tbxScreen.Text = Math.Cosh(primero).ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxScreen.Clear();
            tbxPrevio.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text.Length == 1)
                tbxScreen.Text = "0";
            else
                tbxScreen.Text = tbxScreen.Text.Substring(0, tbxScreen.Text.Length - 1);
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(tbxScreen.Text);
            tbxPrevio.Text = tbxPrevio.Text + tbxScreen.Text + "+";
            tbxScreen.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(tbxScreen.Text);
            tbxPrevio.Text = tbxPrevio.Text + tbxScreen.Text + "−";
            tbxScreen.Clear();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(tbxScreen.Text);
            tbxPrevio.Text = tbxPrevio.Text + tbxScreen.Text + "×";
            tbxScreen.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(tbxScreen.Text);
            tbxPrevio.Text = tbxPrevio.Text + tbxScreen.Text + "÷";
            tbxScreen.Clear();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            primero = double.Parse(tbxScreen.Text);
            resultado = primero;
            tbxPrevio.Text = "√" + tbxPrevio.Text + tbxScreen.Text;
            tbxScreen.Text = Math.Sqrt(primero).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            primero = double.Parse(tbxScreen.Text);
            resultado = primero;
            tbxPrevio.Text = tbxPrevio.Text + tbxScreen.Text + "^2";
            tbxScreen.Text = Math.Pow(primero, 2).ToString();
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text.Contains("."))
            {

            }
            else
            {
                tbxScreen.Text = tbxScreen.Text + ".";
            }
        }

        private void btnN0_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text == "0")
            {
                return;
            }
            else
            {
                tbxScreen.Text = tbxScreen.Text + "0";
            }
        }

        public string ApplicationName
        {
            get { return "TestApp"; }
        }

        public string ApplicationID
        {
            get { return "TestApp"; }
        }

        public Assembly ApplicationAssembly
        {
            get { return Assembly.GetExecutingAssembly(); }
        }

        public Icon ApplicationIcon
        {
            get { return this.Icon; }
        }

        public Uri UpdateXmlLocation
        {
            get { return new Uri("https://raw.githubusercontent.com/henryxrl/SharpUpdate/master/project.xml"); }
        }

        public Form Context
        {
            get { return this; }
        }
    }
}
