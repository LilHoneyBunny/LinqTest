
using LinqColeccion;
using System.Linq;

//Selección números pares

/*int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine("A continuación te mostramos los números pares que existen en el arreglo");

//Sin LINQ
List<int> numerosPares = new List<int>();
foreach (int numero in numeros)
{
    if(numero % 2 == 0)
    {
        numerosPares.Add(numero);
    }
}

//Con LINQ
IEnumerable<int> numerosPares = from numero in numeros 
                                where numero % 2 == 0 
                                select numero;

//Impresión números pares
foreach (int numero in numerosPares)
{
    Console.WriteLine(numero);
}*/

//Ejemplo Constrol Alumno Objetos
ControlAlumnos controlAlumnos = new ControlAlumnos();
controlAlumnos.obtenerAlumnosPorCarrera(1);