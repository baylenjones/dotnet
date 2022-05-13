namespace variables
{
    public class variables
    {
        public void example()
        {

            string name = "Baylen Jones";

            Console.WriteLine("hello world! welcome to reviewing the basics");

            Console.WriteLine("Author: " + name);                              // Basic Output
            string jobTitle = ".Net Developer";                                // string of chars, words
            char middleInt = 'R';                                              // symbol, single char
            int age = 26;                                                      // whole number
            double exp = 99.9;                                                 // decimal number
            bool remote = true;                                                // true or false value

            Console.WriteLine("Job Title: " + jobTitle + "\n" + name + " " + middleInt + "\nAge: " + age + "\nExperience: " + exp + "\nWilling to work remotely: " + remote);

            Console.ReadKey();                                                 // breakpoint for input key to continue

        }
    }
}