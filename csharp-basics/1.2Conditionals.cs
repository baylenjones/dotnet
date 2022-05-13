namespace Conditional
{

    public class Conditional
    {
        public void example()
        {
            string answer1;
            string answer2;

            Console.WriteLine("What is 2 + 2?");
            answer1 = Console.ReadLine();                           // Basic Input

            if (answer1 == "4")
            {                                                       // Conditional If and else statment. If this then do that.
                Console.WriteLine("Corret!");
            }

            else
            {
                Console.WriteLine("Incorrect!");                    // If anything Else, do this
            }

            Console.WriteLine("Guess a Door, 1 , 2, 3: ");
            answer2 = Console.ReadLine();

            switch (answer2)
            {                                                       // Switch statements, another way to sort directions in code.
                case "1":
                    Console.WriteLine("you chose door 1!");
                    break;

                case "2":
                    Console.WriteLine("you chose door 2!");
                    break;

                case "3":
                    Console.WriteLine("you chose door 3!");
                    break;

                default:
                    Console.WriteLine("wrong way!");
                    break;

            }

            Console.ReadKey();
        }
    }
}