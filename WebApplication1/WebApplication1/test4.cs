using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EjemploArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList miArrayList = new ArrayList();
            miArrayList.Add("Primero ");
            miArrayList.Add("Segundo ");
            miArrayList.Add("Tercero ");
            miArrayList.Add("Cuarto ");
            miArrayList.Add("Quinto ");

            foreach (string cadena in miArrayList)
                Console.Write(cadena);

            Console.WriteLine();

            // Accedemos a una posición 
            Console.WriteLine("La segunda cadena es: {0}", miArrayList[1]);

            // Insertamos en la segunda posicion
            miArrayList.Insert(1, "Después de Primero ");
            miArrayList.Insert(0, "Al principio ");

            // Mostramos de otra forma lo que contiene 
            for (int i = 0; i < miArrayList.Count; i++)
                Console.WriteLine(miArrayList[i]);

            // Buscamos un elemento 
            Console.WriteLine("La palabra \"Tercero \" está en la posición {0}",
            miArrayList.IndexOf("Tercero "));

            // Ordenamos 
            miArrayList.Sort();

            // Mostramos lo que contiene 
            Console.WriteLine("Contenido tras ordenar");
            foreach (string frase in miArrayList)
                Console.WriteLine(frase);

            // Buscamos con búsqueda binaria 
            Console.WriteLine("Ahora \"Cuarto \" está en la posición {0}",
            miArrayList.BinarySearch("Cuarto "));

            // Invertimos la lista 
            miArrayList.Reverse();

            // Borramos el segundo dato y la palabra "Quinto " 
            miArrayList.RemoveAt(1);
            miArrayList.Remove("Quinto ");

            // Mostramos nuevamente lo que contiene 
            Console.WriteLine("Contenido dar la vuelta y tras eliminar dos:");
            foreach (string frase in miArrayList)
                Console.WriteLine(frase);

            // Ordenamos y vemos dónde iría un nuevo dato 
            miArrayList.Sort();
            Console.WriteLine("La frase \"Primero \"...");
            int posicion = miArrayList.BinarySearch("Primero ");
            if (posicion >= 0)
                Console.WriteLine("Está en la posición {0}", posicion);
            else
                Console.WriteLine("No está. El dato inmediatamente mayor es el {0}: {1}",
                ~posicion, miArrayList[~posicion]);

            Console.WriteLine("La frase \"Sexto \"...");
            posicion = miArrayList.BinarySearch("Sexto ");
            if (posicion >= 0)
                Console.WriteLine("Está en la posición {0}", posicion);
            else
                Console.WriteLine("No está. El dato inmediatamente mayor es el {0}: {1}",
                ~posicion, miArrayList[~posicion]);

            Console.ReadKey();
        }
    }
}
