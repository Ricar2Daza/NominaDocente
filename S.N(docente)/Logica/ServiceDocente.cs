using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Logica
{
    public class ServiceDocente
    {
        private RepositoryDocente repositoryDocente;
        public ServiceDocente()
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
                    return "Se guardaron los datos de manera exitosa";
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
}
