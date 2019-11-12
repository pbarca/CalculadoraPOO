using System;

namespace CalculadoraPOO
{
    class Calculadora
    {
        private string visor;
        private double mem;

        public Calculadora()
        {
            this.visor = "";
        }

        public string input
        {
            set
            {
                if (visor == "") visor = "0";
                switch (value)
                {
                    case "OFF": visor = ""; break;
                    case "AC": visor = "0"; break;
                    case "C": visor = "0"; break;
                    case "MC":mem = 0; break;
                    case "MR": visor = mem.ToString(); break;
                    case "M-": mem = -ecra; break;
                    case "M+": mem = ecra; break;
                    case "v":; break;
                    case "%":; break;
                    case "+/-":; break;
                    case "/":
                    case "x":
                    case "-":
                    case "+":
                    case "=":; break;
                    case ".": if (!visor.Contains(",")) visor += ","; break;
                    default: visor += value; break;
                }
            }
        }
        private double ecra
        {
            get
            {
                double result;
                try { result = Convert.ToDouble(visor); }
                catch { result = 0; }
                return result;
            }
        }
        public string output
        {
            get
            {
                return (visor.Length > 9) ? visor.Substring(0, 9) : visor;
            }
        }
        public Boolean memory
        {
            get
            {
                return (mem != 0) ? true : false;
            }
        }
    }
}