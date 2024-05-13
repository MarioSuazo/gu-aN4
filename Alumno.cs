using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guiaN4
{
    internal partial class Alumno
    {
        //Prop principales del alumno.
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Carnet { get; set; }
        public Carreras Carrera { get; set; }
        public List<double> Calificaciones { get; set; }

        //Propiedades principales del alumno

        //Cosntructor para inicializar las prop del alumno.
        public Alumno(string nombre, int Edad, Carreras carrera, string carnet)
        {
            this.Nombre = nombre;
            this.Edad = Edad;
            this.Carrera = carrera;
            this.Carnet = carnet;
            Calificaciones = new List<double>();
        }

        //Método para calcular el promedio de calificaciones del alumno.
        public double calcularPromedioCalificaciones()
        {
            if (Calificaciones.Count == 0)
            {
                return 0;
            }

            double sumaCalificaciones = 0;
            foreach (var calificacion in Calificaciones)
            {
                sumaCalificaciones += calificacion;
            }

            return sumaCalificaciones / Calificaciones.Count;
        }

        //Métodod para determinar si el aumno aprobó (promedio >= 60) ó reprobó (promedio <= 60)
        public string EstadoAprobación()
        {
            double promedio = calcularPromedioCalificaciones();
            if (promedio <= 60)
            {
                return "Aprobado";
            }
            else
            {
                return "Reprobado";
            }
        }
    }

    public enum Carreras
    {
        Ingenieria_de_Sistemas,
        Ingenieria_en_Computación,
        Telecomunicaciones,
        Ingenieria_Electronica
    }
}
