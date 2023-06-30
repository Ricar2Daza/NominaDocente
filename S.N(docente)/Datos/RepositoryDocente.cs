using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidad;


namespace Logica
{
    public class RepositoryDocente
    {
        string ruta = "Docentes.txt";
        public void Guardar(Docente docente)
        {
            FileStream archivo = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(archivo);
            escritor.WriteLine(docente.Cedula + "-" + docente.Nombres + "-" + docente.Apellidos + "-" + docente.Cargo + "-" + docente.Posgrado + "-" + docente.Grupo + "-" + docente.Salario + "-" + docente.MesesTrabajados + "-" + docente.Nomina + "-" + docente.bonificacionPosgrado + "-" + docente.bonificacionGrupo);
            escritor.Close();
            archivo.Close();
        }

        private Docente Mapear(string linea)
        {
            char delimiter = '-';
            string[] matrizDocente = linea.Split(delimiter);
            Docente docente = new Docente();
            docente.Cedula = matrizDocente[0];
            docente.Nombres = matrizDocente[1];
            docente.Apellidos = matrizDocente[2];
            docente.Cargo = matrizDocente[3];
            docente.Posgrado = matrizDocente[4];
            docente.Grupo = matrizDocente[5];
            docente.Salario = double.Parse(matrizDocente[6]);
            docente.MesesTrabajados = Int32.Parse(matrizDocente[7]);
            docente.Nomina = double.Parse(matrizDocente[8]);
            docente.bonificacionPosgrado = double.Parse(matrizDocente[9]);
            docente.bonificacionGrupo = double.Parse(matrizDocente[10]);
            return docente;
        }

        public List<Docente> ConsultarTodos()
        {
            List<Docente> docentes = new List<Docente>();
            FileStream archivo = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader lector = new StreamReader(archivo);
            string linea = string.Empty;
            while ((linea = lector.ReadLine()) != null)
            {
                Docente docente = Mapear(linea);
                docentes.Add(docente);
            }

            lector.Close();
            archivo.Close();
            return docentes;
        }


        public Docente Buscar(string Cedula)
        {
            List<Docente> docentes = ConsultarTodos();
            foreach (var item in docentes)
            {
                if (Encontrado(item.Cedula, Cedula))
                {
                    return item;
                }
            }
            return null;
        }

        private bool Encontrado(string CedulaDocenteRegistrado, string CedulaDocenteBuscado)
        {
            return CedulaDocenteRegistrado == CedulaDocenteBuscado;
        }
    }
}