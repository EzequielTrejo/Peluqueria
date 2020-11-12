using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocios
{
    public class NegTurno
    {
        DatosTurno objDT = new DatosTurno();

        public int abmTurno(string accion, Turno objTurno)
        {
            return objDT.AbmTurno(accion, objTurno);
        }

        public DataSet ListarTurnos(string Cual)
        {
            return objDT.ListarTurnos(Cual);
        }

    }
}
