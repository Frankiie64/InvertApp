using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{
    class MenuProduct : Isubmenu
    {
        ServiceProduct servicio = new ServiceProduct();
        public void Submenu()
        {
            try
            {
                Console.Clear();

                Console.WriteLine("Seleccione una de nuestras opciones:\n" +
                    "\n1- Agregar Proudcto\n2- Editar Producto\n3- Eliminar Producto" +
                    "\n4- Listar Producto\n5- Volver atras");

                int opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case (int)SubMenu.agregar:
                        Console.Clear();

                        servicio.add();
                        Submenu();

                        break;

                    case (int)SubMenu.editar:
                        Console.Clear();

                        servicio.Edit();
                        Submenu();

                        break;
                    case (int)SubMenu.eliminar:
                        Console.Clear();

                        servicio.Delete();
                        Submenu();

                        break;
                    case (int)SubMenu.listar:

                        Console.Clear();
                        servicio.list();
                        Console.ReadKey();
                        Submenu();

                        break;

                    case (int)SubMenu.volver:
                        Console.Clear();
                        break;

                    default:

                        Console.Clear();

                        Console.WriteLine("Por favor seleccione algunas de nuestras opciones.");
                        Console.ReadKey();

                        break;

                }
            }
            catch (Exception ex)
            {
                Console.Clear();

                Console.WriteLine("Introduza la respuesta segun los valores marcados anteriormente.");
                Console.ReadKey();

                Submenu();

            }
        }
    }
}
