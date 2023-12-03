using RepasoExamen.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamen.Servicios
{
    internal interface InterfazCliente
    {
        public void darAltaCliente(List<ClienteDto> listaClientes);

        public void modificarCliente(List<ClienteDto> listaClientes);
    }
}
