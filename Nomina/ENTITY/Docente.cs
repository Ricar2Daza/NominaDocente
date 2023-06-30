using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
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
        //public double SMLMV { get => 1000000; set{ } }
        public double BonificacionPostGrado { get; set; }
        public double BonificacionPorGrupo { get; set; }
        public string Contrato { get; set; }

        public double SMLMV = 1000000;
        public double CalcularSalarioAuxiliarTC()
        {
            Salario = SMLMV * 2.645;
            return Salario;
        }
        public double CalcularSalarioAuxiliarMT()
        {
            Salario = SMLMV * 1.509;
            return Salario;
        }

        public double CalcularSalarioAsistenteTC()
        {
            Salario = SMLMV * 3.125;
            return Salario;
        }

        public double CalcularSalarioAsistenteMT()
        {
            Salario = SMLMV * 1.749;
            return Salario;
        }

        public double CalcularSalarioAsociadoTC()
        {
            Salario = SMLMV * 3.606;
            return Salario;
        }

        public double CalcularSalarioAsociadoMT()
        {
            Salario = SMLMV * 1.990;
            return Salario;
        }

        public double CalcularSalarioTitularTC()
        {
            Salario = SMLMV * 3.918;
            return Salario;
        }
        public double CalcularSalarioTitularMT()
        {
            Salario = SMLMV * 2.146;
            return Salario;
        }

        public double BonificacionPostGradoEspecializacion()
        {
            BonificacionPostGrado = SMLMV * 0.10;
            return BonificacionPostGrado;
        }
        public double BonificacionPostGradoMaestria()
        {
            BonificacionPostGrado = SMLMV * 0.45;
            return BonificacionPostGrado;
        }
        public double BonificacionPostGradoDoctorado()
        {
            BonificacionPostGrado = SMLMV * 0.90;
            return BonificacionPostGrado;
        }
        public double BonificacionPostGradoPostDoctorado()
        {
            BonificacionPostGrado = SMLMV * 0;
            return BonificacionPostGrado;
        }

        public double BonificacionGrupoA1()
        {
            BonificacionPorGrupo = SMLMV * 0.56;
            return BonificacionPorGrupo;
        }
        public double BonificacionGrupoA()
        {
            BonificacionPorGrupo = SMLMV * 0.47;
            return BonificacionPorGrupo;
        }
        public double BonificacionGrupoB()
        {
            BonificacionPorGrupo = SMLMV * 0.42;
            return BonificacionPorGrupo;
        }
        public double BonificacionGrupoC()
        {
            BonificacionPorGrupo = SMLMV * 0.38;
            return BonificacionPorGrupo;
        }
        public double BonificacionGrupoReconocidoColCiencias()
        {
            BonificacionPorGrupo = SMLMV * 0.33;
            return BonificacionPorGrupo;
        }
        public double BonificacionGrupoSemillero()
        {
            BonificacionPorGrupo = SMLMV * 0.19;
            return BonificacionPorGrupo;
        }
        public double CalcularNomina(double salario, double bonificacionPostGrado, double bonificacionPorGrupo)
        {
            Salario = salario;
            BonificacionPostGrado = bonificacionPostGrado;
            BonificacionPorGrupo = bonificacionPorGrupo;
            Nomina = (Salario + BonificacionPostGrado + BonificacionPorGrupo) * MesesTrabajados;
            return Nomina;
        }
    }
}
