namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,Enter name");
            string userName = Console.ReadLine();
            Console.WriteLine("press anykey to continue");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"Hello, {userName}");
            Console.WriteLine("lets do a small math question");
            Console.WriteLine("press anykey to continue");
            Console.ReadKey();
            Console.Clear();

            
            Console.WriteLine("Whats 7 + 7 ?");
            Console.ReadLine();
            int correctAnswer = 14;
            int playerGuess = 0;
            Console.ReadKey();
            Console.Clear();


            while (playerGuess != correctAnswer)
            {


                string input = Console.ReadLine();

                bool isNumber = int.TryParse(input, out playerGuess);

                if (isNumber)
                {


                    if (playerGuess < correctAnswer)
                    {

                        Console.WriteLine("too High, try again");
                    }
                    else if (playerGuess < correctAnswer)
                    {
                        Console.WriteLine("too low , try again");
                    }
                    else 
                    {

                        Console.WriteLine("Correct");
                    
                    }
                }
            }

            Console.WriteLine("Press anykey to exit");
            Console.ReadKey();
        }
    }
}
