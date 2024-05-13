using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guiaN4
{
    internal partial class Universidad
    {
        //Lista de alumnos.
        private List<Alumno> listaAlumnos;

        //Constructor para inicializar la lista de alumnos.
        public Universidad()
        {
            listaAlumnos = new List<Alumno>();
        }

        //Método estático para agregar un nuevo alumno a la lista.
        public void agregarAlumno(Alumno alumno)
        {
            listaAlumnos.Add(alumno);
        }

        //Metodo estático para mostrar la lista de alumnos con detalles.
        public List<Alumno> obtenerListaAlumnos()
        {
            return listaAlumnos;
        }
    }
}
