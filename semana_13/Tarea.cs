using System;
using System.Windows;
using System.Windows.Controls;

namespace GuessTheNumber
{
    public class Game
    {
        private int _numberToGuess;
        private int _tries;
        private Random _random;

        public Game()
        {
            _random = new Random();
            _numberToGuess = _random.Next(1, 101);
            _tries = 0;
        }

        public void Play()
        {
            while (true)
            {
                Console.WriteLine("Adivina el número entre 1 y 100");
                string input = Console.ReadLine();

                int guess;
                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Introduce un número válido");
                    continue;
                }

                if (guess < 1 || guess > 100)
                {
                    Console.WriteLine("El número debe ser entre 1 y 100");
                    continue;
                }

                _tries++;

                if (guess == _numberToGuess)
                {
                    Console.WriteLine($"¡Lo has logrado! El número era {guess} y tardaste {_tries} intentos.");
                    break;
                }
                else if (guess < _numberToGuess)
                {
                    Console.WriteLine("El número es mayor");
                }
                else
                {
                    Console.WriteLine("El número es menor");
                }
            }
        }
    }
}