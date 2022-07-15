using System;
using BakeryPastry.Model;
using BakeryBread.Model;

namespace Bakery 
{
  public class Program
  {
    public static void Main()
    {
      Console.Clear();
      Console.WriteLine(" __________________________");
      Console.WriteLine("///////////////////////////|");
      Console.WriteLine("                           |");
      Console.WriteLine("WELCOME TO PIERRE'S BAKERY |");
      Console.WriteLine("___________________________|");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~| \n");
      Console.WriteLine("> Enter any key to start.");
      Console.ReadLine();
      Console.Clear();
      Console.WriteLine("_______________________________");
      Console.WriteLine("//////////////////////////////|");
      Console.WriteLine("|  _  _   ___   _  _   _   _  |");
      Console.WriteLine("| | \\/ | | __| | \\| | | | | | |");
      Console.WriteLine("| | \\/ | | ]_  | \\  | | |_| | |");
      Console.WriteLine("| |_||_| |___| |_|\\_| \\_____/ |");
      Console.WriteLine("|                             |");
      Console.WriteLine("|       [ BAKED GOODS ]       |");
      Console.WriteLine("|  Bread - $5    Pastry - $2  |");
      Console.WriteLine("|  -------------------------  |");
      Console.WriteLine("|        [ DISCOUNTS ]        |");
      Console.WriteLine("| * Bread - Buy 2 Get 1 FREE  |");
      Console.WriteLine("| * Pastry - Buy 2 Get 3rd    |");
      Console.WriteLine("|                  HALF OFF   |");
      Console.WriteLine("|_____________________________| \n");
      Console.WriteLine("Would you like to place an order? \n > Enter Y for YES and ANY OTHER for NO");
      string makeOrder = Console.ReadLine().ToUpper();
      while (makeOrder == "Y")
      {
        Console.Clear();
        Console.WriteLine("_______________________________");
        Console.WriteLine("//////////////////////////////|");
        Console.WriteLine("|                             |");
        Console.WriteLine("| What would you like to order? |");
      }
    }
  }
}