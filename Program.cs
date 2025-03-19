namespace Clase18_03_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

    }
    /*
     PROCEDIMIENTO GIT:
    (Repositorio LOCAL)
    1- git init. ( Solo cuando se inicializa)
    // bucle de trabajo
    2- git add. 
    3- git commit -m "mensaje referencial a lo que voy a subir"
    (Repositorio remoto)
    4-git push (Enviar los cambios)
     
    5-git pull (Traerme los cambios)
     
     */

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
