using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numberToGuess = random.Next(1, 101);
            int playerGuess = 0;
            int attempts = 0;

            Console.WriteLine("Witaj w grze 'Zgadnij liczbę'!");
            Console.WriteLine("Spróbuj odgadnąć liczbę od 1 do 100.");

            while (playerGuess != numberToGuess)
            {
                Console.Write("Podaj swoją próbę: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out playerGuess))
                {
                    Console.WriteLine("To nie jest poprawna liczba.");
                    continue;
                }

                attempts++;

                if (playerGuess > numberToGuess)
                {
                    Console.WriteLine("Za wysoko!");
                }
                else if (playerGuess < numberToGuess)
                {
                    Console.WriteLine("Za nisko!");
                }
            }

            Console.WriteLine("Gratulacje! Odgadłeś liczbę! Liczba prób: {0}", attempts);
        }
    }
}
