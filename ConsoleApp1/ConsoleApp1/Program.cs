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
            miArrayList.Add("Hola ");
            miArrayList.Add("buenos ");
            miArrayList.Add("días.");

            foreach (string cadena in miArrayList)
                Console.WriteLine(cadena);

            // Accedemos a una posición 
            Console.WriteLine("La segunda cadena es: {0}", miArrayList[1]);

            // Insertamos en la segunda posicion 
            miArrayList.Insert(1, "¿Cómo estás?, ");

            // Mostramos de otra forma lo que contiene 
            for (int i = 0; i < miArrayList.Count; i++)
                Console.WriteLine(miArrayList[i]);

            // Buscamos un elemento 
            Console.WriteLine("La palabra \"días.\" está en la posición {0}",
            miArrayList.IndexOf("días."));

            // Ordenamos 
            miArrayList.Sort();

            // Mostramos lo que contiene 
            Console.WriteLine("Contenido tras ordenar");
            foreach (string frase in miArrayList)
                Console.WriteLine(frase);

            // Buscamos con búsqueda binaria 
            Console.WriteLine("Ahora \"días.\" está en la posición {0}",
            miArrayList.BinarySearch("días."));

            // Invertimos la lista 
            miArrayList.Reverse();

            // Borramos el segundo dato y la palabra "días." 
            miArrayList.RemoveAt(1);
            miArrayList.Remove("días.");

            // Mostramos nuevamente lo que contiene 
            Console.WriteLine("Contenido dar la vuelta y tras eliminar dos:");
            foreach (string frase in miArrayList)
                Console.WriteLine(frase);

            // Ordenamos y vemos dónde iría un nuevo dato 
            miArrayList.Sort();
            Console.WriteLine("La frase \"Hola \"...");
            int posicion = miArrayList.BinarySearch("Hola ");
            if (posicion >= 0)
                Console.WriteLine("Está en la posición {0}", posicion);
            else
                Console.WriteLine("No está. El dato inmediatamente mayor es el {0}: {1}",
                ~posicion, miArrayList[~posicion]);

            Console.ReadKey();
        }
    }
}