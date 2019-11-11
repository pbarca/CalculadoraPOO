using System;
using System.Windows.Forms;

namespace CalculadoraPOO
{
    public partial class Form1 : Form
    {
        private Calculadora casio = new Calculadora();
        public Form1()
        {
            InitializeComponent();
        }

        private void clicar(object sender, EventArgs e)
        {
            casio.input = ((Button)sender).Tag.ToString();
            label1.Text = casio.output;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = casio.output;
        }
    }
}