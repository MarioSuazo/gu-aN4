using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace guiaN4
{
    internal class Program
    {
        static Alumno al1 = new Alumno("Ildebrando Casimiro Buarque Castellón", 18, Carreras.Ingenieria_de_Sistemas, "2023-1001U");
        static Alumno al2 = new Alumno("Gonzalo Guillermo Gonzales Guanacaste", 22, Carreras.Telecomunicaciones, "2023-1357U");
        static Alumno al3 = new Alumno("Dante Nicolás Calderón Villamizar", 19, Carreras.Ingenieria_Electronica, "2023-1653U");
        static double p1, p2, p3, p4;
        static void Main(string[] args)
        {
            Console.WriteLine("Hola");
            Universidad UNI = new Universidad();


            califAl1();
            UNI.agregarAlumno(al1);
            al1.EstadoAprobación();
            al1.calcularPromedioCalificaciones();

            califAl2();
            UNI.agregarAlumno(al2);
            al2.EstadoAprobación();
            al2.calcularPromedioCalificaciones();

            califAl3();
            UNI.agregarAlumno(al3);
            al3.EstadoAprobación();
            al3.calcularPromedioCalificaciones();

            Console.WriteLine(UNI.obtenerListaAlumnos());
            
            Console.WriteLine("Fín");
        }

        static void califAl1()
        {
            Console.Write($"Digite la calificación #1: ");
            p1 = Convert.ToDouble(Console.ReadLine());
            al1.Calificaciones.Add(p1);
            Console.Write($"Digite la calificación #2: ");
            p2 = Convert.ToDouble(Console.ReadLine());
            al1.Calificaciones.Add(p2);
            Console.Write($"Digite la calificación #3: ");
            p3 = Convert.ToDouble(Console.ReadLine());
            al1.Calificaciones.Add(p3);
            Console.Write($"Digite la calificación #4: ");
            p4 = Convert.ToDouble(Console.ReadLine());
            al1.Calificaciones.Add(p4);
        }

        static void califAl2()
        {
            Console.Write($"Digite la calificación #1: ");
            p1 = Convert.ToDouble(Console.ReadLine());
            al2.Calificaciones.Add(p1);
            Console.Write($"Digite la calificación #2: ");
            p2 = Convert.ToDouble(Console.ReadLine());
            al2.Calificaciones.Add(p2);
            Console.Write($"Digite la calificación #3: ");
            p3 = Convert.ToDouble(Console.ReadLine());
            al2.Calificaciones.Add(p3);
            Console.Write($"Digite la calificación #4: ");
            p4 = Convert.ToDouble(Console.ReadLine());
            al2.Calificaciones.Add(p4);
        }

        static void califAl3()
        {
            Console.Write($"Digite la calificación #1: ");
            p1 = Convert.ToDouble(Console.ReadLine());
            al3.Calificaciones.Add(p1);
            Console.Write($"Digite la calificación #2: ");
            p2 = Convert.ToDouble(Console.ReadLine());
            al3.Calificaciones.Add(p2);
            Console.Write($"Digite la calificación #3: ");
            p3 = Convert.ToDouble(Console.ReadLine());
            al3.Calificaciones.Add(p3);
            Console.Write($"Digite la calificación #4: ");
            p4 = Convert.ToDouble(Console.ReadLine());
            al3.Calificaciones.Add(p4);
        }

        //static void principal()
        //{

        //}
    }
}
