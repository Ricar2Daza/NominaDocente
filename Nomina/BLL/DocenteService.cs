using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;

namespace BLL
{
    public class DocenteService
    {
        private RepositoryDocente repositoryDocente;
        public DocenteService()
        {
            repositoryDocente = new RepositoryDocente();
        }

        public string Guardar(Docente docente)
        {
            try
            {
                if (repositoryDocente.Buscar(docente.Cedula) == null)
                {
                    repositoryDocente.Guardar(docente);
                    return "Se guardaron los datos correctamente";
                }
                return "No es posible guardar los datos";


            }
            catch (Exception e)
            {
                return "Error:" + e.Message;
            }
        }
        public DocenteConsultaResponse Consultar()
        {
            try
            {
                List<Docente> docentes = repositoryDocente.ConsultarTodos();
                var response = new DocenteConsultaResponse(docentes);
                return response;
            }
            catch (Exception e)
            {
                var response = new DocenteConsultaResponse("Error:" + e.Message);
                return response;
            }
        }


        
    }
    public class DocenteConsultaResponse
    {
        public List<Docente> Docentes { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }
        public bool DocenteEncontrado { get; set; }
        public DocenteConsultaResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
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
