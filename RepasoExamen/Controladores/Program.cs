using RepasoExamen.Servicios;
using RepasoExamen.Dto;
using System;

namespace RepasoExamen
{
    class Program
    {
        static void Main(string[] args)
        {
            InterfazMenu mi=new MenuImplcs();
            InterfazCliente ni = new ClienteImpl();

            List<ClienteDto> listaClientes = new List<ClienteDto>();

            mi.mensBienve();

            bool salir = false;
            int opcion;

            while (!salir)
            {
                opcion = mi.mostrarMenu();
                Console.Clear();

                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("\n\tGracias por usar nuestro programa ");
                        salir = true;
                        break;

                    case 1:
                        Console.WriteLine("\n\n\t[INFO]--Se efectua el alta del nuevo cliente--\n");
                        ni.darAltaCliente(listaClientes);
                        break;

                    case 2:
                        Console.WriteLine("\n\t[INFO]--Modificador de datos del cliente--\n");
                        ni.modificarCliente(listaClientes);
                        break;

                    case 3:
                        break;

                    case 4:
                        Console.WriteLine("\n\tEstos son los clientes registrados: \n");

                        foreach(ClienteDto cliente in listaClientes)
                        {
                            
                            Console.WriteLine("Datos Cliente " + cliente.NombreCliente+": \n");
                            Console.WriteLine(cliente.ToString());
                            Console.WriteLine("\n");
                            
                        }
                        break;

                    default:
                        Console.WriteLine("\n\t[ERROR]--Has seleccionado un opcion incorrecta !!!!\n");
                        break;

                }
            }
        }
    }
}
