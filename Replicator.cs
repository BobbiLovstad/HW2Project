// Written By Bobbi Lovstad
// 2/4/25
namespace ConsoleApp12;

public class Replicator
{
    public static void Main(string[] args)
    {
        // Integer Array that can store 5 numbers 
        int [] original = new int[5];

        // Loop 5 times and ask user for number 
        // Number stored in the original array

        for (int item = 0; item < 5; item++)
        {
            Console.Write ("Type a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            original [item] = num;
        }

        // Copy values from old array and put them in new one 

        int [] copy = new int[5];

        for (int index = 0; index < 5; index++)
            copy[index] = original[index];

         // Display values from both arrrays

        for (int index = 0; index < 5; index++)
           Console.WriteLine ($"{original[index]} and {copy[index]}");

    }
}
