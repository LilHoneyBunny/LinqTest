
using LinqColeccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqColeccion
{
    internal class ControlAlumnos
    {
        List<Carrera> carreras = new List<Carrera>();
        List <Alumno> alumnos = new List<Alumno> ();

        public ControlAlumnos()
        {
            carreras.Add(
                new Carrera { IdCarrera = 1, Nombre = "Ingeniería de Software" });
            carreras.Add(
                new Carrera { IdCarrera = 2, Nombre = "Redes y Servicios de Cómputo" });
            carreras.Add(
                new Carrera { IdCarrera = 3, Nombre = "Tecnologías Computacionales" });
        

        alumnos.Add(new Alumno
        {
            IdAlumno = 1,
            Nombre = "Miriam Lilly Martínez Guzmán",
            Matricula = "s19014025",
            Promedio = 7.3,
            IdCarrera = 1
        });

            alumnos.Add(new Alumno
            {
                IdAlumno = 2,
                Nombre = "Diana Pilar Miranda Estrella",
                Matricula = "s19014038",
                Promedio = 8.8,
                IdCarrera = 1
            });

            alumnos.Add(new Alumno
            {
                IdAlumno = 3,
                Nombre = "Elian Ernesto Sorcia Patiño",
                Matricula = "s19013990",
                Promedio = 8.1,
                IdCarrera = 1
            });

            alumnos.Add(new Alumno
            {
                IdAlumno = 4,
                Nombre = "Manuel Ladrón de Guevara Tello",
                Matricula = "s19030174",
                Promedio = 8.2,
                IdCarrera = 1
            });

        }

        public void obtenerAlumnosPorCarrera(int idCarrera)
        {
            var resultado = from alumno in alumnos join carrera in
                                            carreras on alumno.IdCarrera equals carrera.IdCarrera
                                            where alumno.IdCarrera == idCarrera
                                            select new { Alumno= alumno, Carrera = carrera};

            foreach (var result in resultado)
            {
               
            result.Alumno.getDatosAlumno();
            result.Carrera.getDatosCarrera();
            }
        }
    }
}
