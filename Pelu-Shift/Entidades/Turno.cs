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
        private string nombre;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Peluquero { get => peluquero; set => peluquero = value; }
        public string Dia { get => dia; set => dia = value; }
        public string Horario { get => horario; set => horario = value; }

        public Turno()
        {

        }

        public Turno(string pelu, string day, string hora, string nom)
        {
            nombre = nom;
            peluquero = pelu;
            dia = day;
            horario = hora;
        }
    }
}
