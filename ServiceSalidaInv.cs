using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{
    class ServiceSalidaInv : Isubmenu
    {
        ServiceProduct servicio = new ServiceProduct();

        public void Submenu()
        {
            if (servicio.ValidacionP() == false)
            {
                try
                {
                    servicio.listCant();

                    Console.WriteLine("Cual articulo desea darle salida a la bodega ?");
                    int opc = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    Console.WriteLine($"Cual es la cantidad del {Singlerepositorio.Instancia.NombreProduct[opc - 1].Nombre} que va ha sacar?");
                    int cantidad = Convert.ToInt32(Console.ReadLine());

                    if (Singlerepositorio.Instancia.NombreProduct[opc - 1].Cantidad < cantidad)
                    {
                        Console.WriteLine("La cantidad que desea sacar no se encuentra disponible" +
                            " lo reenviaremos al menu principal.");
                        Console.ReadKey();

                    }
                    else
                    {
                        Singlerepositorio.Instancia.NombreProduct[opc - 1].Cantidad -= cantidad;

                        Console.WriteLine($"La operacion se ha ejecutado exitomasamente ahora tiene" +
                            $" {Singlerepositorio.Instancia.NombreProduct[opc - 1].Cantidad} de {Singlerepositorio.Instancia.NombreProduct[opc - 1].Nombre} en " +
                            $"el inventario.");
                        Console.ReadKey();
                    }

                }
                catch
                {
                    Console.WriteLine("Por favor llenar los datos segun su las opciones que aparecen.");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("No ha ingresado ningun producto, por favor cree alguna para poder darle entrada a los mismos.");
                Console.ReadKey();
            }
        }
        
    }
}
