namespace ConsoleApp9;

public class Discounted
{
   public static void Main(string[]args) 
   {
      Console.WriteLine("This is the inventory");
      Console.WriteLine("1- Rope");
      Console.WriteLine("2- Torches");
      Console.WriteLine("3- Climbing Equipment");
      Console.WriteLine("4- Clean Water");
      Console.WriteLine("5- Machete");
      Console.WriteLine("6- Canoe");
      Console.WriteLine("7- Food Supplies");
      Console.Write("Type a number to see the price of something in the inventory");

      // Convert from string to integer

      int ItemNum = Convert.ToInt32(Console.ReadLine());

      // Switch 
      // Set the inventory to a certain number
      // Switch the inventory item to respective price
      
       string Item = ItemNum switch
        {
            1=> "Rope",
            2=> "Torches",
            3=> "Climbing Equipment",
            4=> "Clean Water",
            5=> "Machete",
            6=> "Canoe",
            7=> " Food Supplies"

        };

        int Price = Item switch
        {
            "Rope" => 10,
            "Torches" => 15,
            "Climbing Equipment" => 25,
            "Clean Water" => 1,
            "Machete" => 20,
            "Canoe" => 200,
            "Food Supplies" =>1
        };

       
        // Ask User for their name

        Console.Write ("Enter your name");
        string name = Console.ReadLine();

        // if the name of the user is equal to my name, price of item is cut in half 

        if (name == "Bobbi") Price/ = 2;

        // Display cost of item 

        Console.WriteLine($"{Item} costs {Price} gold")
    }
}

   

