using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{
    class MenuPrincipal
    {
        Isubmenu submenu;
        public void menu()
        {
            try
            {
                Console.Clear();

                Console.WriteLine("Seleccione una de nuestras opciones:\n" +
                    "\n1- Mantenimientos de categorias\n2- Mantenimientos de productos\n3- Entrada de  inventario" +
                    "\n4- Salida de  inventario\n5- Salir");

                int opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case (int)Menu.MantenCateg:

                        Console.Clear();
                       
                        submenu = new MenuCategoria();
                        submenu.Submenu();

                        menu();
                        break;

                    case (int)Menu.MantenProduc:
                        Console.Clear();

                        submenu = new MenuProduct();
                        submenu.Submenu();

                        menu();
                        break;

                    case (int)Menu.EntradaInven:
                        Console.Clear();
                        submenu = new ServiceEntradaInv();
                        submenu.Submenu();

                        menu();
                        break;

                    case (int)Menu.SalidaInven:
                        Console.Clear();

                        submenu = new ServiceSalidaInv();
                        submenu.Submenu();

                        menu();
                        break;
                    case (int)Menu.salir:

                        Console.Clear();                                               
                        break;

                    default:

                        Console.Clear();

                        Console.WriteLine("Por favor seleccione algunas de nuestras opciones.");
                        Console.ReadKey();

                        menu();

                        break;

                }    
            }
            catch (Exception ex)
            {
                Console.Clear();

                Console.WriteLine("Introduza la respuesta segun los valores marcados anteriormente.");
                Console.ReadKey();

                menu();
            }
        }
    }
}
