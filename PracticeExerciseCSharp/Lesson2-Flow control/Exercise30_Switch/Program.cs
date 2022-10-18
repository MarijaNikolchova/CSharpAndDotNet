using System;

namespace Exercise30_Switch
{
    internal class Program
    {
        /// <summary>
        /// Create a C# program to display the "text mark" corresponding to a certain 
        /// "numerical mark", using the following equivalence:
        /// 
        /// 9,10 = Sobresaliente
        /// 7,8 = Notable
        /// 6 = Bien
        /// 5 = Aprobado
        /// 0-4 = Suspenso
        /// Your program must ask the user for a numerical mark and display the corresponding text mark.
        /// You must do it twice: first using "if" and then using "switch".
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            int number;

            Console.Write("Number? ");
            number = Convert.ToInt32(Console.ReadLine());

            if ((number == 9) || (number == 10))
                Console.WriteLine("Sobresaliente");
            else if ((number == 7) || (number == 8))
                Console.WriteLine("Notable");
            else if (number == 6)
                Console.WriteLine("Bien");
            else if (number == 5)
                Console.WriteLine("Aprobado");
            else if ((number >= 0) && (number <= 4))
                Console.WriteLine("Suspenso");
            else
                Console.WriteLine("No válido");

            switch (number)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Suspenso");
                    break;
                case 5:
                    Console.WriteLine("Aprobado");
                    break;
                case 6:
                    Console.WriteLine("Bien");
                    break;
                case 7: goto case 8;
                case 8:
                    Console.WriteLine("Notable");
                    break;
                case 9:
                    Console.WriteLine("Bajo, pero... ");
                    goto case 10;
                case 10:
                    Console.WriteLine("Sobresaliente");
                    break;
                default:
                    Console.WriteLine("Nota no válida");
                    break;
            }
    }
}
