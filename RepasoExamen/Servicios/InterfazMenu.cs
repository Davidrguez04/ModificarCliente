using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamen.Servicios
{
    internal interface InterfazMenu
    {
        public void mensBienve();

        public int mostrarMenu();

        public string pedirDni();

        public int pedirCampos();
    }
}
