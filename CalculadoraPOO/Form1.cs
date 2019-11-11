using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraPOO
{
    public partial class Form1 : Form
    {
        Calculadora casio = new Calculadora();
        public Form1()
        {
            InitializeComponent();
        }

        private void clicar(object sender, EventArgs e)
        {
            casio.input = ((Button)sender).Tag.ToString();
            label1.Text = casio.output;
        }
    }
}
