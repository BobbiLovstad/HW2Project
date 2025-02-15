// Written By Bobbi Lovstad
// 2/4/25
namespace ConsoleApp7;

public class Class1
{
    public static void Main(string{})
    {
        // Ask user for x and y coordinates of the enemy

        Console.Write("X Coordinate");
        int X = Convert.ToInt32(Console.ReadLine());

        Console.Write("Y Coordinate");
        int Y = Convert.ToInt32(Console.ReadLine());

        // If Statements
        // 9 possible locations of the enemy
        //Display the location of enemy based on the coordinates entered by user

        if (X < 0 && Y > 0) Console.WriteLine("Enenmy is to the NorthWest");
        if (X == 0 && Y > 0) Console.WriteLine("Enenmy is to the North");
        if (X > 0 && Y > 0) Console.WriteLine("Enenmy is to the NorthEast");
        if (X < 0 && Y == 0) Console.WriteLine("Enenmy is to the West");
        if (X == 0 && Y == 0) Console.WriteLine("Enenmy is to the Here");
        if (X > 0 && Y == 0) Console.WriteLine("Enenmy is to the East");
        if (X < 0 && Y < 0) Console.WriteLine("Enenmy is to the SouthWest");
        if (X == 0 && Y < 0) Console.WriteLine("Enenmy is to the South");
        if (X > 0 && Y < 0) Console.WriteLine("Enenmy is to the SouthEast");
    }
}
        

        

        

        

        

        

        

        



    }
}
