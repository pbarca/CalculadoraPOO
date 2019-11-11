using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPOO
{
    class Calculadora
    {
    private string visor;
        public string input
        {
            set { visor = value; }
        }
        public string output
        {
            get { return visor; }
        }
    }
}
