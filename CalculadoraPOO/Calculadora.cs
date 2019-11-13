using System;

namespace CalculadoraPOO
{
    class Calculadora
    {
        private string visor, operador = "";
        private double mem, anterior;
        private bool op;

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
                    case "OFF": visor = ""; mem = 0; break;
                    case "AC": visor = "0"; mem = 0; break;
                    case "C": visor = "0"; break;
                    case "MC": mem = 0; break;
                    case "MR": visor = mem.ToString(); break;
                    case "M-": mem -= ecra; break;
                    case "M+": mem += ecra; break;
                    case "v": visor = Math.Sqrt(ecra).ToString(); break;
                    case "%": visor = (anterior * ecra / 100).ToString(); break;
                    case "+/-": visor = (-ecra).ToString(); break;
                    case "/":
                    case "x":
                    case "-":
                    case "+":
                    case "=": operar = value; break;
                    default: adicionar = value; break;
                }
            }
        }

        private string operar
        {
            set
            {
                if (operador == "") anterior = ecra;
                if (!op) switch (operador)
                    {
                        case "+": anterior += ecra; break;
                        case "-": anterior -= ecra; break;
                        case "x": anterior *= ecra; break;
                        case "/": anterior /= ecra; break;
                        case "=": anterior = ecra; break;
                    }
                visor = anterior.ToString();
                operador = value;
                op = true;
            }
        }
        private string adicionar
        {
            set
            {
                if (op)
                {
                    visor = "0";
                    op = false;
                }
                if (value == ".")
                {
                    if (!visor.Contains(",")) visor += ",";
                    return;
                }
                if (visor == "0") visor = value;
                else visor += value;
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