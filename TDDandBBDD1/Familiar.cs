namespace TDDandBBDD1
{
    public class Familiar
    {
        private string nombre { get; set;}
        public static bool fallecido { get; set; }

        public void cargarNombre(string strNombre)
        {
            nombre = strNombre;  
        }

        public string leerNombre()
        {
            return nombre;
        }

        public void defuncion()
        {
            fallecido = true;   
        }

        public bool esFallecido()
        {
            return fallecido;
        }
    }
}