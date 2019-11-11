namespace CalculadoraPOO
{
    class Calculadora
    {
        private string visor;

        public Calculadora()
        {
            this.visor = "";
        }

        public string input
        {
            set
            {
                this.visor += value;
            }
        }
        public string output
        {
            get
            {
                return (visor.Length > 9) ? visor.Substring(0, 9) : visor;
            }
        }
    }
}