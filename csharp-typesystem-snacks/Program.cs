namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PRIMA TASK
            // ------------

            Console.WriteLine("- PRIMA TASK -");

            int firstNumber;
            int secondNumber;

            Console.WriteLine("primo numero: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("secondo numero: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Il numero più grande é: " + int.Max(firstNumber, secondNumber));

            // SECONDA TASK
            // ------------

            Console.WriteLine("- SECONDA TASK -");

            string firstWord;
            string secondWord;

            Console.WriteLine("prima parola: ");
            firstWord = Convert.ToString(Console.ReadLine());
            Console.WriteLine("seconda parola: ");
            secondWord = Convert.ToString(Console.ReadLine());

            if (firstWord.Length < secondWord.Length) 
            {
                Console.WriteLine("La parola più corta é: " + firstWord);
                Console.WriteLine("La parola più lunga é: " + secondWord);
            } else if(secondWord.Length > firstWord.Length)
            {
                Console.WriteLine("La parola più corta é: " + secondWord);
                Console.WriteLine("La parola più lunga é: " + firstWord);
            } else 
            {
                Console.WriteLine("Le parole hanno stessa lunghezza!");
            }

            // TERZA TASK
            // -----------

            Console.WriteLine("- TERZA TASK -");

            int numberOne;
            int numberTwo;
            int numberThree;
            int numberFour;
            int numberFive;
            int numberSix;
            int numberSeven;
            int numberEight;
            int numberNine;
            int numberTen;

            Console.WriteLine("Inserisci un numero");
            numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci un numero");
            numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci un numero");
            numberThree = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci un numero");
            numberFour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci un numero");
            numberFive = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci un numero");
            numberSix = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci un numero");
            numberSeven = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci un numero");
            numberEight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci un numero");
            numberNine = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci un numero");
            numberTen = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(numberOne + numberTwo + numberThree + numberFour + numberFive + numberSix + numberSeven + numberEight + numberNine + numberTen);

            // QUARTA TASK
            // -----------

            Console.WriteLine("- QUARTA TASK -");




            // QUINTA TASK
            // -----------

            Console.WriteLine("- QUINTA TASK -");

            int number;

            Console.WriteLine("Inserisci un numero");
            number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("il numero é pari: " + number);
            } else
            {
                Console.WriteLine("il numero é dispari, quindi: " + (number + 1));
            }

            // SESTA TASK
            // ----------

            Console.WriteLine("- SESTA TASK -");

            string[] grandeGatsby = { "Michele", "Giovanni", "Davide", "Gabriele", "Sara", "Francesco"};

            string name;

            Console.WriteLine("Inserisci il tuo nome per vedere se puoi partecipare alla festa!");
            name = Convert.ToString(Console.ReadLine());

            if (Array.Exists(grandeGatsby, element => element.Contains($"{name}")))
            {
                Console.WriteLine("Il tuo nome é presente nella lista, buon divertimento!");
            } else
            {
                Console.WriteLine("Il tuo nome non é presente nella lista, ci dispiace!");
            }

            // SETTIMA TASK
            // ------------

            Console.WriteLine("- SETTIMA TASK -");

        }
    }
}
