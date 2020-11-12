using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
using System.Data;
using Datos;

namespace Negocios
{
    public class NegCliente
    {
        DatosCliente datosCliente = new DatosCliente();

        public int abmCliente(Cliente objCliente)
        {
            return datosCliente.AltaCliente(objCliente);
        }
    }
}