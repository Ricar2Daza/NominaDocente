using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DAL
{
    public class RepositoryDocente
    {
        readonly string documento = "Docente.txt";
        public void Guardar(Docente docente)
        {
            FileStream file = new FileStream(documento, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(docente.Cedula + ";" + docente.Nombres + ";" + docente.Apellidos + ";"  + docente.Contrato
                + ";" + docente.Cargo + ";" + docente.Posgrado + ";" + docente.Grupo + ";" 
                + docente.Salario + ";" + docente.MesesTrabajados + ";" + docente.Nomina + ";"
                + docente.BonificacionPostGrado + ";" + docente.BonificacionPorGrupo);
            writer.Close();
            file.Close();
        }

        private Docente MapearDocente(string linea)
        {
            char delimiter = ';';
            string[] partesDocente = linea.Split(delimiter);
            Docente docente = new Docente();
            docente.Cedula = partesDocente[0];
            docente.Nombres = partesDocente[1];
            docente.Apellidos = partesDocente[2];
            docente.Contrato = partesDocente[3];
            docente.Cargo = partesDocente[4];
            docente.Posgrado = partesDocente[5];
            docente.Grupo = partesDocente[6];
            docente.Salario = double.Parse(partesDocente[7]);
            docente.MesesTrabajados = int.Parse(partesDocente[8]);
            docente.Nomina = double.Parse(partesDocente[9]);
            docente.BonificacionPostGrado = double.Parse(partesDocente[10]);
            docente.BonificacionPorGrupo = double.Parse(partesDocente[11]);
            return docente;
        }

        public List<Docente> ConsultarTodos()
        {
            List<Docente> docentes = new List<Docente>();
            FileStream file = new FileStream(documento, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {
                Docente docente = MapearDocente(linea);
                docentes.Add(docente);
            }
            reader.Close();
            file.Close();
            return docentes;
        }

        public Docente Buscar(string Cedula)
        {
            List<Docente> docentes = ConsultarTodos();
            foreach (var item in docentes)
            {
                if (Encontrar(item.Cedula, Cedula))
                {
                    return item;
                }
            }
            return null;
        }
        private bool Encontrar(string CedulaDocenteRegistrado, string CedulaDocenteBuscar)
        {
            return CedulaDocenteRegistrado == CedulaDocenteBuscar;
        }
    }
}
