using System;
using BakeryPastry.Model;
using BakeryBread.Model;

namespace Bakery 
{
  public class Program
  {
    public static void Main()
    {
      Bread baseBread = new Bread("1");
      baseBread.GetPrice();
      Pastry basePastry = new Pastry("1");
      basePastry.GetPrice();

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
      Console.WriteLine($"|  Bread - ${baseBread.Price}    Pastry - ${basePastry.Price}  |");
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
        Console.WriteLine("_________________________________");
        Console.WriteLine("////////////////////////////////|");
        Console.WriteLine("|                               |");
        Console.WriteLine("| What would you like to order? |");
        Console.WriteLine("|_______________________________|");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~| \n");
        Console.WriteLine("> Enter B for BREAD and P for PASTRY");
        string selected = Console.ReadLine().ToUpper();
        if (selected == "B")
        {
          breadLoop();
          string breadOrder = Console.ReadLine();
          Bread userBread = new Bread(breadOrder);
          userBread.GetPrice();
          int breadCost = userBread.Price;
          int breadAmount = userBread.Amount;
          Console.Clear();
          breadCostLoop(breadCost, breadAmount);
          string breadCorrect = Console.ReadLine().ToUpper();
          if (breadCorrect != "Y")
          {
            breadLoop();
            breadOrder = Console.ReadLine();
            userBread = new Bread(breadOrder);
            userBread.GetPrice();
            breadCost = userBread.Price;
            breadAmount = userBread.Amount;
            Console.Clear();
            breadCostLoop(breadCost, breadAmount);
            breadCorrect = Console.ReadLine().ToUpper();
          }
          Console.WriteLine("> Enter C for CHECKOUT or P for PASTRY");
          selected = Console.ReadLine().ToUpper();
        }
        else if (selected == "P")
        {
          pastryLoop();
          string pastryOrder = Console.ReadLine();
          Pastry userPastry = new Pastry(pastryOrder);
          userPastry.GetPrice();
          int pastryCost = userPastry.Price;
          int pastryAmount = userPastry.Amount;
          Console.Clear();
          pastryCostLoop(pastryCost, pastryAmount);
          string pastryCorrect = Console.ReadLine().ToUpper();
          if (pastryCorrect != "Y")
          {
            pastryLoop();
            pastryOrder = Console.ReadLine();
            userPastry = new Pastry(pastryOrder);
            userPastry.GetPrice();
            pastryCost = userPastry.Price;
            pastryAmount = userPastry.Amount;
            Console.Clear();
            pastryCostLoop(pastryCost, pastryAmount);
            pastryCorrect = Console.ReadLine().ToUpper();
          }

          Console.WriteLine("> Enter C for CHECKOUT or P for PASTRY");
          selected = Console.ReadLine().ToUpper();
        }
        else if (selected == "C")
        {

        }

        void breadLoop()
        {
          Console.Clear();
          Console.WriteLine("_________________________________");
          Console.WriteLine("////////////////////////////////|");
          Console.WriteLine("|                               |");
          Console.WriteLine("| How many loaves of bread      |");
          Console.WriteLine("|      would you like to order? |");
          Console.WriteLine("|_______________________________|");
          Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~| \n");
          Console.WriteLine("> Enter number of loaves to add to cart.");
        }

        void breadCostLoop(int breadCost, int breadAmount)
        {
          Console.WriteLine("____________________________");
          Console.WriteLine("///////////////////////////|");
          Console.WriteLine("|                          |");
          Console.WriteLine($"| Your total is ${breadCost} for    |");
          Console.WriteLine($"|       {breadAmount} loaves of bread. |");
          Console.WriteLine("|__________________________|");
          Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~| \n");
          Console.WriteLine("> Is this correct? \n> Enter Y for YES and N for NO");
        }

        void pastryLoop()
        {
          Console.Clear();
          Console.WriteLine("_____________________________");
          Console.WriteLine("////////////////////////////|");
          Console.WriteLine("|                           |");
          Console.WriteLine("| How many pastries would   |");
          Console.WriteLine("|        you like to order? |");
          Console.WriteLine("|___________________________|");
          Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~| \n");
          Console.WriteLine("> Enter number of pastries to add to cart.");
        }

        void pastryCostLoop(int pastryCost, int pastryAmount)
        {
          Console.WriteLine("____________________________");
          Console.WriteLine("///////////////////////////|");
          Console.WriteLine("|                          |");
          Console.WriteLine($"|  Your total is ${pastryCost}       |");
          Console.WriteLine($"|     for {pastryAmount} of pastries.   |");
          Console.WriteLine("|__________________________|");
          Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~| \n");
          Console.WriteLine("> Is this correct? \n> Enter Y for YES and N for NO");
        }
      }

          

    }
  }
}