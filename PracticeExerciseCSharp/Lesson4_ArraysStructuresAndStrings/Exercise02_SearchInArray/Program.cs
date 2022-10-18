using System;

namespace Exercise02_SearchInArray
{
    /// <summary>
    /// Create a program that says if a data belongs in a list that was previously created.
    /// 
    /// The steps to take are:
    /// - Ask the user how many data will he enter.
    /// - Reserve space for that amount of numbers(floating point).
    /// - Request the data to the user
    /// - Later, repeat:
    /// * Ask the user for a number(execution ends when he enters "end" instead of a number).
    /// * Say if that number is listed or not.
    /// 
    /// Must be done in pairs.but you must provide a single source file, containing the names of 
    /// both programmers in a comment.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cuantos datos reservo: ");
            int repeticiones = Convert.ToInt32(Console.ReadLine());
            float numero;
            float[] listaNumeros = new float[repeticiones];

            for (int i = 1; i <= repeticiones; i++)
            {
                Console.Write("Dime numero {0} para guardar en la lista: ", i);
                listaNumeros[i] = Convert.ToSingle(Console.ReadLine());
            }

            Console.Write("Que numero comprueba en la lista? ");
            numero = Convert.ToSingle(Console.ReadLine());

            while (Console.ReadLine() != "end")
            {
                for (int i = 1; i <= repeticiones; i++)
                {
                    if (listaNumeros[i] == numero)
                        Console.WriteLine("El número {0} existe en la lista", numero);
                }
            }
        }
    }
}
