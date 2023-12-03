using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamen.Dto
{
    internal class ClienteDto
    {
        //Atributos
        string nombreCliente="aaaaa";

        string apellidosCliente="aaaaaa";

        string dniCliente="aaaaa";

        string fchNacimientoCliente="9999/12/31";

        string emailCliente;

        int tlfCliente;

        string fchAltaCliente= "9999/12/31";

        string fchBajaCliente= "9999/12/31";

        long id;

        string iban;

        string codigoS = "CSI1SSXX";

        string contraseña;


        //Getters y setters
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string FchNacimientoCliente { get => fchNacimientoCliente; set => fchNacimientoCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public int TlfCliente { get => tlfCliente; set => tlfCliente = value; }
        public string FchAltaCliente { get => fchAltaCliente; set => fchAltaCliente = value; }
        public string FchBajaCliente { get => fchBajaCliente; set => fchBajaCliente = value; }
        public long Id { get => id; set => id = value; }
        public string Iban { get => iban; set => iban = value; }
        public string CodigoS { get => codigoS; set => codigoS = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }

        //Constructores
        public ClienteDto(string nombreCliente, string apellidosCliente, string dniCliente, string fchNacimientoCliente, string emailCliente, int tlfCliente, string fchAltaCliente, string fchBajaCliente, long id, string iban, string codigoS, string contraseña)
        {
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.dniCliente = dniCliente;
            this.fchNacimientoCliente = fchNacimientoCliente;
            this.emailCliente = emailCliente;
            this.tlfCliente = tlfCliente;
            this.fchAltaCliente = fchAltaCliente;
            this.fchBajaCliente = fchBajaCliente;
            this.id = id;
            this.iban = iban;
            this.codigoS = codigoS;
            this.contraseña = contraseña;

        }
        public ClienteDto()
        {
        }

        //Método ToString

        override
            public string ToString()
        {
            string cliente = "Nombre: " + this.nombreCliente +
                "\nApellidos: " + this.apellidosCliente +
                "\nDni: " + this.dniCliente +
                "\nFechaNac: " + this.fchNacimientoCliente +
                "\nEmail: " + this.emailCliente +
                "\nTelefono: " + this.tlfCliente +
                "\nFecha Alta: " + this.fchAltaCliente+
                "\nId: " + this.id +
                "\nIban: ES14" + this.iban +
                "\nCodigo Switch: " + this.codigoS ;

            return cliente; 
        }
    }
}
