using RepasoExamen.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamen.Servicios
{
    internal class ClienteImpl:InterfazCliente
    {
        public void darAltaCliente(List<ClienteDto>listaClientes)
        {
            ClienteDto cliente = crearNuevoCliente();

            listaClientes.Add(cliente);
        }

        private ClienteDto crearNuevoCliente()
        {
            ClienteDto cliente = new ClienteDto();

            Console.WriteLine("Introduzca su nombre: ");
            cliente.NombreCliente = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Introduzca sus apellidos: ");
            cliente.ApellidosCliente = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Introduzca su Dni: ");
            cliente.DniCliente = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Introduzca su fecha nacimiento: ");
            cliente.FchNacimientoCliente = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Introduzca su email: ");
            cliente.EmailCliente = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Introduzca su telefono: ");
            cliente.TlfCliente = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca la fechaAlta: ");
            cliente.FchAltaCliente = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Introduzca un id: ");
            cliente.Id = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Introduzca su Iban: ");
            cliente.Iban = Convert.ToString(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Perfecto, ahora introduzca una contraseña: ");
            cliente.Contraseña = Convert.ToString(Console.ReadLine());

            return cliente;
        }

        public void modificarCliente(List<ClienteDto>listaClientes)
        {
            InterfazMenu mi=new MenuImplcs();
            ClienteDto clienteM = new ClienteDto();

            string dniBuscar=mi.pedirDni();
            int campo;
            bool salir = false;

            foreach(ClienteDto cliente in listaClientes)
            {
                if (cliente.DniCliente.Equals(dniBuscar))
                {
                    clienteM = cliente;
                    

                    while (!salir) {
                        campo = mi.pedirCampos();
                        Console.Clear();

                        switch (campo)
                        {
                            case 0:
                                salir = true;
                                break;

                            case 1:
                                Console.WriteLine("Introduzca el nombre: ");
                                cliente.NombreCliente = Convert.ToString(Console.ReadLine());
                                break;

                            case 2:
                                Console.WriteLine("Introduzca los apellidos: ");
                                cliente.ApellidosCliente = Convert.ToString(Console.ReadLine());
                                break;

                            case 3:
                                Console.WriteLine("Introduzca el dni: ");
                                cliente.DniCliente = Convert.ToString(Console.ReadLine());
                                break;

                            case 4:
                                Console.WriteLine("Introduzca la fecha de nacimiento: ");
                                cliente.FchNacimientoCliente = Convert.ToString(Console.ReadLine());
                                break;

                            case 5:
                                Console.WriteLine("Introduzca el email: ");
                                cliente.EmailCliente = Convert.ToString(Console.ReadLine());
                                break;

                            case 6:
                                Console.WriteLine("Introduzca el telefono: ");
                                cliente.TlfCliente = Convert.ToInt32(Console.ReadLine());
                                break;

                            case 7:
                                Console.WriteLine("Introduzca la fecha de alta: ");
                                cliente.FchAltaCliente = Convert.ToString(Console.ReadLine());
                                break;

                            case 8:
                                Console.WriteLine("Introduzca el id: ");
                                cliente.Id = Convert.ToInt64(Console.ReadLine());
                                break;

                            case 9:
                                Console.WriteLine("Introduzca el Iban: ");
                                cliente.Iban = Convert.ToString(Console.ReadLine());
                                break;

                            case 10:
                                Console.WriteLine("Para poder cambiar la contraseña debe introducir la antigua: ");
                                string contraseñaa = Convert.ToString(Console.ReadLine());

                                if (cliente.Contraseña == contraseñaa)
                                {
                                    Console.WriteLine("Contraseña correcta!!!");
                                    Console.WriteLine("Introduzca la nueva contraseña: ");
                                    cliente.Contraseña = Convert.ToString(Console.ReadLine());
                                }
                                else
                                {
                                    Console.WriteLine("[ERROR]--La contraseña introducida no es correcta !!!");

                                }
                                
                                break;

                            default:
                                Console.WriteLine("[ERROR]--Opcion seleccionada incorrecta !!!!");
                                break;
                        }

                    }
                }
                else
                {
                    Console.WriteLine("\n\t[ERROR]--No se encuentra el dni puesto, Vuelva a intentarlo");
                    break;
                }
            } 
        }
    }
}
