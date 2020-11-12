using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Turno
    {
        private string dia;
        private string horario;
        private string peluquero;

        public string Peluquero { get => peluquero; set => peluquero = value; }
        public string Dia { get => dia; set => dia = value; }
        public string Horario { get => horario; set => horario = value; }

        public Turno()
        {

        }

        public Turno(string pelu, string day, string hora)
        {
            peluquero = pelu;
            dia = day;
            horario = hora;
        }
    }
}
