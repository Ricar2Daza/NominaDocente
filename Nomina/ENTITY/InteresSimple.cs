using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Prestamo
    {
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Monto { get; set; }
        public double TasaDeInteres { get; set; }
        public int TiempoSegunTipo { get; set; };

        public double InteresSimple(int Monto, double TasaDeInteres, int TiempoSegunTipo);{
             Monto = monto;
             TasaDeInteres = tasaDeInteres;
             TiempoSegunTipo = tiempoSegunTipo;
             ValorFinal = Monto * TasaDeInteres * TiempoSegunTipo; 
    return ValorFinal;
    }



}