// Written By Bobbi Lovstad
// 2/4/25
namespace ConsoleApp11;

public class Cannon
{
    public static void Main(string[])
    {
        // Loop through values between 1-100

        for (int num = 1; num <= 100; num ++)
        {
            // if statements 5 and 3 blasts is fire and electric 
            if (num % 5 == 0 && num % 3 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{num}: Electric and Fire");
            }
            // 5 cranks changes color to yellow for electric blast 
            else if ( num % 5 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{num}: Electric");
            }
            else if (num % 3 == 0)
            {
                // 3 cranks changes color to red for fire blast
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{num}: Fire");
            }
            else
            {
                // No cranks color is white and normal blast
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{num}: Normal");
            }
        }
    }
}
