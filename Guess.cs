// Written By Bobbi Lovstad
// 2/4/25
namespace ConsoleApp1;

public class Prototype
{
    public static void Main(string[]args)
    {
        // do whie loop 
        // Ensure number is between 0-100 keeps looping until a valid number is entered 

        int num;
        do
        {
            Console.Write("Enter a number between 0 and 100:");
            num = Convert.ToInt32(Console.ReadLine());
        }
        while (num < 0 || num > 100);
        Console.Clear();

        // User guesses number
        // while true loop repeatdly asks user to guess a number


        Console.WriteLine("Guess the number");

        while(true)
        {
            Console.Write("Enter your next guess");
            int guess = Convert.ToInt32(Console.ReadLine());

            //Compare guess to actual number 
            // Displays variance in guess as too high or too low
            // Loop breaks if the guess is correct

            if (guess > num) Console.WriteLine($" {guess} is too high");
            else if ( guess < num) Console.WriteLine($"{guess} is too low");
            else break;
        }
        Console.WriteLine ("You guessed right");
    }
}
