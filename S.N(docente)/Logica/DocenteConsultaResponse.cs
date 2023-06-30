using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Logica
{
    public class DocenteConsultaResponse
    {
        public List<Docente> Docentes { get; set; }
        public string Message { get; set; }
        public bool Error { get; set; }
        public bool DocenteEncontrado { get; set; }
        public DocenteConsultaResponse(string message)
        {
            Error = true;
            Message = message;
            DocenteEncontrado = false;
        }
        public DocenteConsultaResponse(List<Docente> docentes)
        {
            Docentes = docentes;
            Error = false;
            DocenteEncontrado = true;
        }
    }
}
