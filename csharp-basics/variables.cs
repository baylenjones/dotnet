namespace variables {
public class var {
public void example() {

string name = "Baylen Jones";

Console.Write("hello world! welcome to reviewing the basics\n"); // basic output
Console.Write("Author: " + name);

string jobTitle = ".Net Developer";  // string of chars, words
char middleInt = 'R';                // symbol, single char
int age = 26;                        // whole number
double exp = 99.9;                   // decimal number
bool remote = true;                  // true or false value

Console.WriteLine("\nJob Title: " + jobTitle + "\n" + name + " " + middleInt + "\nAge: " + age + "\nExperience: " + exp + "\nWilling to work remotely: " + remote);

Console.ReadKey();                   // breakpoint for input key to continue

        }
    }
}