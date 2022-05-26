using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{
    class ServiceCategoria
    {

        public void add()
        {

            try
            {
                Console.Clear();

                Console.WriteLine("Cual es el nombre de la categoria, que desea ingresar?");

                string name = Console.ReadLine();

                OCategoria categoria = new OCategoria(name);

                Singlerepositorio.Instancia.listCateg.Add(categoria);

                Console.WriteLine("\nEl nombre se ha guardado correctamente.");
                Console.ReadKey();
                
            }
            catch 
            {
                Console.Clear();

                Console.WriteLine("Introduzca un nombre para la nueva categoria.");
                Console.ReadKey();
                            
            }
        }
        public void list()
        {
            Console.Clear();

            int X = 1;
            foreach (OCategoria item in Singlerepositorio.Instancia.listCateg)
            {
                Console.WriteLine($"{X}- {item.Nombre}");

                X++;
            
            }       

        }
        public void Edit()
        {

            try
            {
                list();
                Console.WriteLine("\nCual categoria desea editar?");                

                int option = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                Console.WriteLine("Cual es el nuevo nombre de la categoria, que desea ingresar?");

                string name = Console.ReadLine();

                OCategoria categoria = new OCategoria(name);

                Singlerepositorio.Instancia.listCateg[option -1 ].Nombre =name;

                Console.WriteLine("\nEl nombre se ha guardado correctamente.");
                Console.ReadKey();


            }
            catch
            {
                Console.Clear();

                Console.WriteLine("Introduzca un nombre para la nueva categoria.");
                Console.ReadKey();

            }
        }
        public void Delete()
        {

            try
            {
                list();

                Console.WriteLine("\nCual categoria desea eliminar?");
                
                int option = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                Singlerepositorio.Instancia.listCateg.RemoveAt(option - 1);

                Console.WriteLine("\nLa categoria se ha eliminado correctamente.");
                Console.ReadKey();


            }
            catch
            {
                Console.Clear();

                Console.WriteLine("Introduzca un nombre para la nueva categoria.");
                Console.ReadKey();

            }
        }

    }
}
