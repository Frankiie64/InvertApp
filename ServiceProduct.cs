using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{
    class ServiceProduct
    {
        ServiceCategoria servicio = new ServiceCategoria();

        public bool Validacion()
        {
            if (Singlerepositorio.Instancia.listCateg.Count == 0)
            {

                return true;
            }
            else
            {

                return false;

            }

        }
        public bool ValidacionP()
        {
            if (Singlerepositorio.Instancia.NombreProduct.Count == 0)
            {

                return true;
            }
            else
            {

                return false;

            }

        }
        public void add()
        {

            if (Validacion() == false)
            {
                try
                {
                    Console.Clear();

                    Console.WriteLine("Cual es el nombre del producto, que desea ingresar?");

                    string name = Console.ReadLine();

                    Console.WriteLine($"Cual es el precio del {name}, que ha ingresado ingresar?");
                    int precio = Convert.ToInt32(Console.ReadLine());

                    string categoria = GetCateg();

                    OProducto product = new OProducto(name, precio, categoria);

                    Singlerepositorio.Instancia.NombreProduct.Add(product);

                    Console.WriteLine("\nEl proudcto se ha guardado correctamente.");
                    Console.ReadKey();


                }
                catch
                {
                    Console.Clear();

                    Console.WriteLine("Introduzca un nombre para la nueva categoria.");
                    Console.ReadKey();

                }
            }
            else
            {
                Console.WriteLine("No ha ingresado ninguna categoria, por favor cree alguna para poder agregar algun producto.");
                Console.ReadKey();
            
            }
        }

        public void list()
        {
            Console.Clear();

            int X = 1;
            foreach (OProducto item in Singlerepositorio.Instancia.NombreProduct)
            {
                Console.WriteLine($"{X}- {item.Nombre} - {item.Precio}$ - {item.Categoria}");             
                X++;
            }

        }
        public void listName()
        {
            Console.Clear();

            int X = 1;
            foreach (OProducto item in Singlerepositorio.Instancia.NombreProduct)
            {
                Console.WriteLine($"{X}- {item.Nombre}");
                X++;
            }

        }
        public void listCant()
        {
            Console.Clear();

            int X = 1;
            foreach (OProducto item in Singlerepositorio.Instancia.NombreProduct)
            {
                Console.WriteLine($"{X}- {item.Nombre} - {item.Cantidad}");
                X++;
            }

        }
        public void Edit()
        {
            if (Validacion() == false)
            {

                try
                {
                    listName();
                    Console.WriteLine("\nCual producto desea editar?");

                    int option = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    Console.WriteLine("Cual es el nuevo nombre del producto, que desea ingresar?");

                    string name = Console.ReadLine();

                    Console.WriteLine("Cual es el nuevo precio del producto, que desea ingresar?");

                    int precio = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    string categoria = GetCateg();


                    OProducto product = new OProducto(name, precio, categoria);

                    Singlerepositorio.Instancia.NombreProduct[option - 1] = product;

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
            else
            {
                Console.WriteLine("No ha ingresado ninguna categoria, por favor cree alguna para poder agregar algun producto.");
                Console.ReadKey();

            }
        }
        public void Delete()
        {
            if (Validacion() == false)
            {

                try
                {
                    listName();

                    Console.WriteLine("\nCual producto desea eliminar?");

                    int option = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("Esta seguro que desea eliminar el producto S/N");
                    string opcion = Console.ReadLine();

                    if (opcion.ToLower() == "s")
                    {
                        Singlerepositorio.Instancia.NombreProduct.RemoveAt(option - 1);

                        Console.WriteLine("\nLa categoria se ha eliminado correctamente.");
                        Console.ReadKey();
                    }
                    else if (opcion.ToLower() == "n")
                    {
                        Console.WriteLine("Sera redirigido al menu de producto.");
                        Console.ReadKey();

                    }
                    else
                    {
                        Console.WriteLine("Se esperaba una respuesta diferente, sera redirigido al menu de producto.");
                        Console.ReadKey();

                    }

                }
                catch
                {
                    Console.Clear();

                    Console.WriteLine("Introduzca un nombre para la nueva categoria.");
                    Console.ReadKey();

                }
            }
            else
            {
                Console.WriteLine("No ha ingresado ninguna categoria, por favor cree alguna para poder agregar algun producto.");
                Console.ReadKey();
            }
          
        }

        public string GetCateg()
        {
            string categoria;
            int opc;

            try
            {
                servicio.list();

                Console.WriteLine("\nCual es la nueva categoria del producto, que desea ingresar?");

                opc = Convert.ToInt32(Console.ReadLine());

                categoria = Singlerepositorio.Instancia.listCateg[opc - 1].Nombre;
                return categoria;
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Por favor introduzca un dato segun lo pedido.");
                Console.ReadKey();
                return null;
            }
            
        }

       


    }
}
