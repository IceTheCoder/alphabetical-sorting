using System;

namespace Average_calculator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("How many words do you have that you want to order alphabetically?");
            int length = Convert.ToInt16(Console.ReadLine());

            string[] words = new string[length];

            Console.WriteLine("Type your words and press ENTER after each one.");

            for (int i = 0; i < length; i++)
            {
                words[i] = Console.ReadLine();
            }

            Array.Sort(words);

            Console.WriteLine("-------------");

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(words[i]);
            }

            // Wait before closing.
            Console.ReadKey();
        }
    }
}