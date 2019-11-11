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
