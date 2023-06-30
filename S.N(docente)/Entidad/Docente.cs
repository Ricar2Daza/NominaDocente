using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Docente
    {
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cargo { get; set; }
        public string Posgrado { get; set; }
        public string Grupo { get; set; }
        public double Salario { get; set; }
        public int MesesTrabajados { get; set; }
        public double Nomina { get; set; }
        public double bonificacionPosgrado { get; set; }

        public double bonificacionGrupo { get; set; }

        public double smmlv = 1000000;//, bonificacionPosgrado, bonificacionGrupo;
        public Docente()
        {
        }
        // CALCULAR SALARIO POR CATEGORIA DE DOCENTE OCASIONAL (TIEMPO COMPLETO & MEDIO TIEMPO)
        public double CalcularSalarioAuxiliarTC()
        {           
            Salario = smmlv * 2.645;
            return Salario;
        }
        public double CalcularSalarioAuxiliarMT()
        {
            Salario = smmlv * 1.509;
            return Salario;
        }
        public double CalcularSalarioAsistenteTC()
        {
            Salario = smmlv * 3.125;
            return Salario;
        }
        public double CalcularSalarioAsistenteMT()
        {
            Salario = smmlv * 1.749;
            return Salario;
        }
        public double CalcularSalarioAsociadoTC()
        {
            Salario = smmlv * 3.606;
            return Salario;
        }
        public double CalcularSalarioAsociadoMT()
        {
            Salario = smmlv * 1.990;
            return Salario;
        }
        public double CalcularSalarioTitularTC()
        {
            Salario = smmlv * 3.918;
            return Salario;
        }
        public double CalcularSalarioTitularMT()
        {
            Salario = smmlv * 2.146;
            return Salario;
        }
        // CALCULAR BONIFICACION DE DOCENTE POR POSGRADO
        public double BonificacionEspecializacion()
        {
            bonificacionPosgrado = smmlv * 0.10;
            return bonificacionPosgrado;
        }
        public double BonificacionMaestria()
        {
            bonificacionPosgrado = smmlv * 0.45;
            return bonificacionPosgrado;
        }
        public double BonificacionDoctorado()
        {
            bonificacionPosgrado = smmlv * 0.90;
            return bonificacionPosgrado;
        }
        public double BonificacionPostDoctorado()
        {
            bonificacionPosgrado = smmlv;
            return bonificacionPosgrado;
        }
        //CALCULAR BONIFICACION POR GRUPOS Y/O SEMILLEROS A LOS QUE PERTENECE
        public double BonificacionGrupoA1()
        {
            bonificacionGrupo = smmlv * 0.56;
            return bonificacionGrupo;
        }
        public double BonificacionGrupoA()
        {
            bonificacionGrupo = smmlv * 0.47;
            return bonificacionGrupo;
        }
        public double BonificacionGrupoB()
        {
            bonificacionGrupo = smmlv * 0.42;
            return bonificacionGrupo;
        }
        public double BonificacionGrupoC()
        {
            bonificacionGrupo = smmlv * 0.38;
            return bonificacionGrupo;
        }
        public double BonificacionGrupoReconocido()
        {
            bonificacionGrupo = smmlv * 0.33;
            return bonificacionGrupo;
        }
        public double BonificacionGrupoSemillero()
        {
            bonificacionGrupo = smmlv * 0.19;
            return bonificacionGrupo;
        }

        public double CalcularNomina(double salario, double Grado, double grupo)
        {
            Salario = salario;
            bonificacionPosgrado = Grado;
            bonificacionGrupo = grupo;
            Nomina = (Salario + bonificacionPosgrado + bonificacionGrupo) * MesesTrabajados;
            return Nomina;
        }
    }
}
