using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosConexionDB
    {
        public SqlConnection cn;
        public string CadenaConexion = @"Data Source=.;Initial Catalog=Peluqueria;Integrated Security=True";

        public DatosConexionDB()
        {
            cn = new SqlConnection(CadenaConexion);
        }

        public void AbrirConexion()
        {
            try
            {
                if (cn.State == ConnectionState.Broken || cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }

            }
            catch (Exception e)
            {

                throw new Exception("Error al abrir la base de datos", e);
            }
        }

        public void CerrarConexion()
        {
            try
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            catch (Exception e)
            {

                throw new Exception("Error al cerrar la base de datos", e);
            }
        }

    }
}
