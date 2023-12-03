using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamen.Servicios
{
    internal class MenuImplcs:InterfazMenu
    {
        public void mensBienve()
        {
            string mensaje = "Bienvenido al banco David Santander ";
            Console.WriteLine("\n\t\t\t\t\t "+mensaje);
        }

        public int mostrarMenu()
        {
            int opcion;

            Console.WriteLine("\n\tMenu:");
            Console.WriteLine("\t0-> Salir");
            Console.WriteLine("\t1-> Dar alta nuevo cliente: ");
            Console.WriteLine("\t2-> Modificar datos de cliente: ");
            Console.WriteLine("\t3->");
            Console.WriteLine("\t4-> Mostrar clientes");
            Console.Write("\nSeleccione una opcion: ");

            opcion = Console.ReadKey(true).KeyChar - ('0');

            return opcion;
        }

        public string pedirDni()
        {
            string dni;
            Console.WriteLine("Introduzca su Dni: ");
            dni = Convert.ToString(Console.ReadLine());

            return dni;
        }

        public int pedirCampos()
        {
            int opcion;
            Console.WriteLine("\n\tMenu campos:");
            Console.WriteLine("\t0-> Salir");
            Console.WriteLine("\t1-> Nombre: ");
            Console.WriteLine("\t2-> Apellidos");
            Console.WriteLine("\t3-> Dni");
            Console.WriteLine("\t4-> Fecha Nacimiento");
            Console.WriteLine("\t5-> Email");
            Console.WriteLine("\t6-> Telefono");
            Console.WriteLine("\t7-> Fecha Alta");
            Console.WriteLine("\t8-> Id");
            Console.WriteLine("\t9-> Iban");
            Console.WriteLine("\t10-> Contraseña");
            Console.Write("\nSeleccione una opcion: ");

            opcion =Convert.ToInt32(Console.ReadLine());

            return opcion;

        }


    }
}
