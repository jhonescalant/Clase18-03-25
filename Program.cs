namespace Clase18_03_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

    }

    public class pokemon 
    {
        // Atributos
        public string nombre;
        public int salud;
        public string raza;

        //Metodos
        public void atacar() 
        {
            Console.WriteLine(" Ataco !");
        }

        public void defender()
        {
            Console.WriteLine("Activo defensa");
        
        }

    }



}
