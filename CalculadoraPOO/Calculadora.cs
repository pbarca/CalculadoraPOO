using System;

namespace CalculadoraPOO
{
    class Calculadora
    {
        private string visor, operador;
        private double mem, num1, num2;
        private bool limpar, op;

        public Calculadora()
        {
            this.reset();
        }

        private void reset()
        {
            operador = visor = "";
            mem = num1 = num2 = 0;
            limpar = op = true;
        }
        private void calcula()
        {
            if (op) num1 = ecra; else num2 = ecra;
            switch (operador)
            {
                case "+": visor = (num1 + num2).ToString(); break;
                case "-": visor = (num1 - num2).ToString(); break;
                case "×": visor = (num1 * num2).ToString(); break;
                case "÷": visor = (num1 / num2).ToString(); break;
                case "=": visor = num1.ToString(); break;
            }
            num1 = ecra;
            limpar = true;
            op = true;
        }
        private void adiciona(string botao)
        {
            op = false;
            if (limpar) { visor = "0"; limpar = false; }
            if ((botao == ".") && (!visor.Contains(","))) visor += ",";
            else if (visor == "0") visor = botao;
            else visor += botao;
        }
        private double ecra
        {
            get
            {
                double valor;
                try { valor = Convert.ToDouble(visor); }
                catch { valor = 0; }
                return valor;
            }
        }
        public string input
        {
            set
            {
                if (visor == "") visor = "0";
                switch (value)
                {
                    case "MR": visor = mem.ToString(); break;
                    case "MC": mem = 0; break;
                    case "M-": mem -= ecra; break;
                    case "M+": mem += ecra; break;
                    case "√": visor = Math.Sqrt(ecra).ToString(); break;
                    case "OFF": reset(); break;
                    case "AC": reset(); visor = "0"; break;
                    case "C": visor = "0"; break;
                    case "+/-": visor = (-ecra).ToString(); break;
                    case "%": visor = (ecra / 100 * num1).ToString(); break;
                    case "+":
                    case "-":
                    case "×":
                    case "÷": calcula(); operador = value; break;
                    case "=": calcula(); break;
                    default: adiciona(value); break;
                }
            }
        }
        public string output
        {
            get
            {
                return (visor.Length > 10) ? visor.Substring(0, 10) : visor;
            }
        }
        public bool memory
        {
            get
            {
                return (mem == 0) ? false : true;
            }
        }
    }
}