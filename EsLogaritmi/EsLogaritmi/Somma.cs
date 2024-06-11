using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsLogaritmi
{
    public static class Somma
    {
        public static void sumNumber()
        {
            int n1 = 0;
            int n2 = 0;
            var sum = 0;
            bool isCheck = false;

            while (!isCheck)
            {
                Console.WriteLine("Inserisci Il primo numero da sommare:");
                var input1 = Console.ReadLine();

                Console.WriteLine("Inserisci il secondo numero da sommare:");
                var input2 = Console.ReadLine();

                Console.Clear();

                if ((!String.IsNullOrEmpty(input1)) && (!String.IsNullOrEmpty(input2)))
                {
                    var isNumeric1 = Int32.TryParse(input1, out int num1);
                    var isNumeric2 = Int32.TryParse(input2, out int num2);

                    if ((isNumeric1) && (isNumeric2))
                    {
                        n1 = num1;
                        n2 = num2;
                        isCheck = true;
                    }
                    else
                        Console.WriteLine("Input non validi. Inserisci un numero intero.\n");
                }
                else
                    Console.WriteLine("I dati inseriti non sono validi.\n");

            }

            if (n1 == n2)
            {
                sum = n1 + n2;
                var moltiply = sum * 3;
                Console.WriteLine($"La somma dei tuoi numeri moltiplicata per 3 è: {moltiply}");
            }
            else
                Console.WriteLine($"La somma dei tuoi numeri è: {sum = n1 + n2}");

            playAgain();
        }

        private static void playAgain()
        {
            Console.WriteLine("\nVuoi continuare a sommare numeri? 'si' o 'no'.");

            var playAgain = false;

            while (!playAgain)
            {
                var answer = Console.ReadLine().ToLower().Trim();

                if ((!String.IsNullOrEmpty(answer)) && (answer == "si"))
                {
                    playAgain = true;
                    Console.Clear();
                    sumNumber();
                }
                else
                {
                    Console.WriteLine("\nAlla prossima!");
                    playAgain = true;
                }
            }
        }
    }
}
