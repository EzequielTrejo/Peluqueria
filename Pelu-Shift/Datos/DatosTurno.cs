using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosTurno : DatosConexionDB
    {

        public DataTable TraerDisponibilidad(string Nombre)
        {
            DataTable Temp = new DataTable();
            Temp = Select(Nombre);
            return Temp;
        }

        public int AbmTurno(string accion, Turno objTurno)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Alta")
            {
                orden = "Insert into Turno(Peluquero2, Dia, Horario) values('" + objTurno.Peluquero + "', '" + objTurno.Dia + "', '" + objTurno.Horario + "')";
            }

            if (accion == "Modificar")
            {
                orden = "Update Turno set" 
                    + " Dia = '" + objTurno.Dia + "'," 
                    + " Horario = '" + objTurno.Horario + "'"
                    + " where Peluquero2 = " + "\'" + objTurno.Peluquero + "\'";
            }

            if (accion == "Cancelar")
            {
                orden = "delete from Turno where Dia = " + objTurno.Dia + "' and " + "Horario = '" + objTurno.Horario + "' and " + "Peluquero2 = '" + objTurno.Peluquero + "')";
            }

            SqlCommand command = new SqlCommand(orden, cn);

            try
            {
                cn.Open();
                resultado = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception("Error al tratar de guardar, modificar o eliminar el turno", e);
            }
            finally
            {
                cn.Close();
                command.Dispose();
            }
            return resultado;
        }

        public DataSet ListarTurnos(string Cual)
        {
            string orden = string.Empty;
            if (Cual != "todos")
            {
                orden = "Select * from Turno where Dia = " + int.Parse(Cual) + ";";
            }
            else
            {
                orden = "Select * from Turno;";
            }

            SqlCommand cmd = new SqlCommand(orden, cn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {

                throw new Exception("Error al listar turnos", e);
            }

            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }

            return ds;
        }

        public DataTable Select(string Name)
        {
            string orden = string.Empty;
                orden = "Select * from Peluquero where Nombre = " + "'" + Name + "'" + ";";
            SqlCommand cmd = new SqlCommand(orden, cn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(dt);
            }
            catch(Exception e)
            {

                throw new Exception("Error al listar Disponibilidad", e);
            }

            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return dt;
        }

    }
}
