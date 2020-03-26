using System;

namespace Lab2POO
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Cancion cancion1 = new Cancion();
            Console.WriteLine(cancion1.Informacion());

            Console.WriteLine("Buenos días");
            string cancion;
            Console.WriteLine("Ingrese una cancion:");

            //Creo una variable con el nombre que da el usuario
            cancion = Console.ReadLine();
            //como se usa if y else
            if (cancion == "poto")
            {
                Console.WriteLine("Kie pero como");
            }
            else
            {
                Console.WriteLine("Como pero Kiee");
            }



        }
    }
}
