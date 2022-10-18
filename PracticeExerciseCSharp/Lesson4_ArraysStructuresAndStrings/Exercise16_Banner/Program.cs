using System;

namespace Exercise16_Banner
{
    /// <summary>
    /// Create a C# program to imitate the basic Unix SysV "banner" utility, 
    /// able to display big texts like these:
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] esqueleto =
       {
            "         ###  ### ###  # #   ##### ###   #  ##     ###  ",
            "         ###  ### ###  # #  #  #  ## #  #  #  #    ###  ",
            "         ###   #   # ########  #   ### #    ##      #   ",
            "          #            # #   #####    #    ###     #    ",
            "                     #######   #  #  # ####   # #       ",
            "         ###           # #  #  #  # #  # ##    #        ",
            "         ###           # #   ##### #   ### #### #       ",
            "   ##    ##                                            #",
            "  #        #   #   #    #                             # ",
            " #          #   # #     #                            #  ",
            " #          # ####### #####   ###   #####           #   ",
            " #          #   # #     #     ###           ###    #    ",
            "  #        #   #   #    #      #            ###   #     ",
            "   ##    ##                   #             ###  #      ",
            "  ###     #    #####  ##### #      ####### ##### #######",
            " #   #   ##   #     ##     ##    # #      #     ##    # ",
            "#     # # #         #      ##    # #      #          #  ",
            "#     #   #    #####  ##### #    # ###### ######    #   ",
            "#     #   #   #            ########      ##     #  #    ",
            " #   #    #   #      #     #     # #     ##     #  #    ",
            "  ###   ##### ####### #####      #  #####  #####   #    ",
            " #####  #####    #     ###      #           #     ##### ",
            "#     ##     #  ###    ###     #             #   #     #",
            "#     ##     #   #            #     #####     #        #",
            " #####  ######         ###   #                 #     ## ",
            "#     #      #   #     ###    #     #####     #     #   ",
            "#     ##     #  ###     #      #             #          ",
            " #####  #####    #     #        #           #       #   ",
            " #####    #   ######  ##### ###### ############## ##### ",
            "#     #  # #  #     ##     ##     ##      #      #     #",
            "# ### # #   # #     ##      #     ##      #      #      ",
            "# # # ##     ####### #      #     ######  #####  #  ####",
            "# #### ########     ##      #     ##      #      #     #",
            "#      #     ##     ##     ##     ##      #      #     #",
            " ##### #     #######  ##### ###### ########       ##### ",
            "#     #  ###        ##    # #      #     ##     ########",
            "#     #   #         ##   #  #      ##   ####    ##     #",
            "#     #   #         ##  #   #      # # # ## #   ##     #",
            "#######   #         ####    #      #  #  ##  #  ##     #",
            "#     #   #   #     ##  #   #      #     ##   # ##     #",
            "#     #   #   #     ##   #  #      #     ##    ###     #",
            "#     #  ###   ##### #    # ########     ##     ########",
            "######  ##### ######  ##### ########     ##     ##     #",
            "#     ##     ##     ##     #   #   #     ##     ##  #  #",
            "#     ##     ##     ##         #   #     ##     ##  #  #",
            "###### #     #######  #####    #   #     ##     ##  #  #",
            "#      #   # ##   #        #   #   #     # #   # #  #  #",
            "#      #    # #    # #     #   #   #     #  # #  #  #  #",
            "#       #### ##     # #####    #    #####    #    ## ## ",
            "#     ##     ######## ##### #       #####    #          ",
            " #   #  #   #      #  #      #          #   # #         ",
            "  # #    # #      #   #       #         #  #   #        ",
            "   #      #      #    #        #        #               ",
            "  # #     #     #     #         #       #               ",
            " #   #    #    #      #          #      #               ",
            "#     #   #   ####### #####       # #####        #######",
            "  ###                                                   ",
            "  ###     ##   #####   ####  #####  ###### ######  #### ",
            "   #     #  #  #    # #    # #    # #      #      #    #",
            "        ###### #    # #      #    # #      #      #  ###",
            "    #   #    # #####  #      #    # #####  #####  #     ",
            "        #    # #    # #    # #    # #      #      #    #",
            "        #    # #####   ####  #####  ###### #       #### ",
            "                                                        ",
            " #    #    #        # #    # #      #    # #    #  #### ",
            " #    #    #        # #   #  #      ##  ## ##   # #    #",
            " ######    #        # ####   #      # ## # # #  # #    #",
            " #    #    #        # #  #   #      #    # #  # # #    #",
            " #    #    #   #    # #   #  #      #    # #   ## #    #",
            " #    #    #    ####  #    # ###### #    # #    #  #### ",
            "                                                        ",
            " #####   ####  #####   ####   ##### #    # #    # #    #",
            " #    # #    # #    # #         #   #    # #    # #    #",
            " #    # #    # #    #  ####     #   #    # #    # #    #",
            " #####  #  # # #####       #    #   #    # #    # # ## #",
            " #      #   #  #   #  #    #    #   #    #  #  #  ##  ##",
            " #       ### # #    #  ####     #    ####    ##   #    #",
            "                       ###     #     ###   ##    # # # #",
            " #    #  #   # ###### #        #        # #  #  # # # # ",
            "  #  #    # #      #  #        #        #     ## # # # #",
            "   ##      #      #  ##                 ##        # # # ",
            "   ##      #     #    #        #        #        # # # #",
            "  #  #     #    #     #        #        #         # # # ",
            " #    #    #   ######  ###     #     ###         # # # #"
    };

            Console.Write("Tell a string:");
            string Entry = Console.ReadLine();

            byte j = 1;
            char Letra;
            int[] CodigoAscii = new int[Entry.Length];

            for (int i = 0; i < Entry.Length; i++)
            {
                Letra = Convert.ToChar(Entry.Substring(i, j));
                CodigoAscii[i] = Convert.ToInt32(Letra);
            }

            int AnchoLetras = 7, AltoLetra = 7;
            int numeroAscii = 32;
            int countLineas = 0, countLetras = 0, countPosiciones = 0;
            bool LetraEncontrada = false;
            string[] cadena = new string[AltoLetra];

            for (int i = 0; i < CodigoAscii.Length; i++)
            {
                // Recorro todos las filas del esqueleto de letras
                for (int row = 0; row < esqueleto.Length; row++)
                {
                    if (countLetras == 8)
                    {
                        row += AltoLetra - 1;
                        countLetras = 0;
                        countPosiciones = 0;
                    }
                    //Si no la encuentro tengo que ir aumento la posicion y el numero ascii 
                    while ((!LetraEncontrada) && (countLetras < 8))
                    {
                        if (CodigoAscii[i] == numeroAscii)
                            LetraEncontrada = true;
                        else
                        {
                            numeroAscii++;
                            countPosiciones += AnchoLetras;
                            countLetras++;
                        }
                    }
                    //Si la e encontrado y no tengo las 7 lineas de la letra
                    if ((LetraEncontrada) && (countLineas < 7))
                    {
                        if (i > 0)
                            cadena[countLineas] = cadena[countLineas] + esqueleto[row].Substring(countPosiciones, AnchoLetras);
                        else
                            cadena[countLineas] = esqueleto[row].Substring(countPosiciones, AnchoLetras);
                        countLineas++;
                    }
                }
                countLineas = 0;
                numeroAscii = 32;
                LetraEncontrada = false;
                countPosiciones = 0;
                countLetras = 0;
            }

            //Muestro
            for (int i = 0; i < cadena.Length; i++)
                Console.WriteLine(cadena[i]);
        }
    }
}
