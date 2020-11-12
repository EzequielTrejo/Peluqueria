using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosCliente : DatosConexionDB
    {
        int resultado = -1;
        public int AltaCliente(Cliente cliente)
        {
            try
            {
                cn.Open();
                string query = @" Insert into Cliente (Nombre) values ('" + cliente.Nombre + "')";

                SqlCommand command = new SqlCommand(query, cn);

                resultado = command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }
    }
}
