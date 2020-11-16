using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Datos;
namespace UnitTestTurnos.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InsertData()
        {
            Turno objTurno = new Turno();
            var Dia = "Martes";
            var Horario = "9:00hs";
            var Peluquero = "Jose Ramos";
            var NombreCliente = "Ragnar";
            objTurno.Dia = Dia;
            objTurno.Horario = Horario;
            objTurno.Peluquero = Peluquero;
            objTurno.Nombre = NombreCliente;
            DatosTurno abm = new DatosTurno();
            abm.AbmTurno("Alta", objTurno);
        }
    }
}
