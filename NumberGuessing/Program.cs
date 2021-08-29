using System;

namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Start();
            
            Console.WriteLine("Try again?: ");
            var again = Console.ReadLine();

            if (again == "yes")
            {
                p.Start();
            }
            else
            {
                Console.WriteLine("suck a dick");
            }
            
            p.Start();
            Console.Read();
        }

        public void Start()
        {
            Console.WriteLine("Choose difficulty: easy, normal, hard");
            var difficulty = Console.ReadLine();
            Program p = new Program();

            if (difficulty == "easy")
            {
                p.Easy();
            } else if (difficulty == "normal")
            {   
                p.Normal();
            } else if (difficulty == "hard")
            {
                p.Hard();
            }
        }

        public void Easy()
        {
            int[] numbers = new[] {1, 2, 3};
            Random random = new Random();
            Console.WriteLine("Difficulty: Easy");
            Console.WriteLine("Guess The number");

            var rndMember = numbers[random.Next(numbers.Length)];
            var guess = Convert.ToInt32(Console.ReadLine());

            if (guess == rndMember)
            {
                Console.WriteLine("Your guess was correct");
            }
            else if (guess >= numbers.Length)
            {
                Console.WriteLine("The chosen number is out of bounds");
            }
            else if (guess != rndMember)
            {
                Console.WriteLine("Your guess was incorrect");
            }
        }

        public void Normal()
        {
            int[] numbers = new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9,};
            Random random = new Random();
            Console.WriteLine("Difficulty: Normal");
            Console.WriteLine("Guess The number");

            var rndMember = numbers[random.Next(numbers.Length)];
            var guess = Convert.ToInt32(Console.ReadLine());

            if (guess == rndMember)
            {
                Console.WriteLine("Your guess was correct");
            }
            else if (guess >= numbers.Length)
            {
                Console.WriteLine("The chosen number is out of bounds");
            }
            else if (guess != rndMember)
            {
                Console.WriteLine("Your guess was incorrect");
            }
        }

        public void Hard()
        {
            int[] numbers = new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
            Random random = new Random();
            Console.WriteLine("Difficulty: Hard");
            Console.WriteLine("Guess The number");

            var rndMember = numbers[random.Next(numbers.Length)];
            var guess = Convert.ToInt32(Console.ReadLine());

            if (guess == rndMember)
            {
                Console.WriteLine("Your guess was correct");
            }
            else if (guess >= numbers.Length)
            {
                Console.WriteLine("The chosen number is out of bounds");
            }
            else if (guess != rndMember)
            {
                Console.WriteLine("Your guess was incorrect");
            }
        }
    }
}