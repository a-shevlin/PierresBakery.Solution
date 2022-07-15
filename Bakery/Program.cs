using System;
using BakeryPastry.Model;
using BakeryBread.Model;
using BakeryCart.Model;

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

      Cart userCart = new Cart(0, 0, 0, 0);
      int brAmount = userCart.BreadAmount;
      int brPrice = userCart.BreadPrice;
      int paAmount = userCart.PastryAmount;
      int paPrice = userCart.PastryPrice;

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
      Console.WriteLine("Would you like to place an order? \n> Enter Y for YES and ANY OTHER for NO");
      string makeOrder = Console.ReadLine().ToUpper();
      while (makeOrder == "Y")
      {
        Console.Clear();
        Console.WriteLine("_____________________________________");
        Console.WriteLine("////////////////////////////////////|");
        Console.WriteLine("|                                   |");
        Console.WriteLine("| [ BREAD ] [ PASTRY ] [ CHECKOUT ] |");
        Console.WriteLine("|___________________________________|");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~| \n");
        Console.WriteLine("> Enter B for BREAD or P for PASTRY or C for CHECKOUT");
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
          brAmount = breadAmount;
          brPrice = breadCost;
        }
        else if (selected == "P")
        {
          pastryLoop();
          string pastryOrder = Console.ReadLine();
          Pastry userPastry = new Pastry(pastryOrder);
          userPastry.GetPrice();
          int pastryCost = userPastry.Price;
          int pastryAmount = userPastry.Amount;
          pastryCostLoop(pastryCost, pastryAmount);
          string pastryCorrect = Console.ReadLine().ToUpper();
          if (pastryCorrect != "Y")
          {
            Console.Clear();
            pastryLoop();
            pastryOrder = Console.ReadLine();
            userPastry = new Pastry(pastryOrder);
            userPastry.GetPrice();
            pastryCost = userPastry.Price;
            pastryAmount = userPastry.Amount;
            pastryCostLoop(pastryCost, pastryAmount);
            pastryCorrect = Console.ReadLine().ToUpper();
          }
          paAmount = pastryAmount;
          paPrice = pastryCost;
        }
        else if (selected == "C")
        {
          Console.Clear();
          Console.WriteLine("________________________________");
          Console.WriteLine("///////////////////////////////|");
          Console.WriteLine("|                              |");
          Console.WriteLine("|  Are you ready to checkout?  |");
          Console.WriteLine("|______________________________|");
          Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~| \n");
          Console.WriteLine("> Enter Y for YES and N for NO");
          string ready = Console.ReadLine().ToUpper();
          if (ready == "Y")
          {
            Console.Clear();
            int total = paPrice + brPrice;
            Console.WriteLine("____________________________");
            Console.WriteLine("///////////////////////////|");
            Console.WriteLine("|                          |");
            Console.WriteLine($"| Your total is ${total} for    |");
            Console.WriteLine($"|      {brAmount} loaves of bread.  |");
            Console.WriteLine($"|              {paAmount} pastries. |");
            Console.WriteLine("|__________________________|");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~| \n");
            Console.WriteLine("> Would you like to purchase?");
            Console.WriteLine("> Enter Y for YES and N for NO");
            string checkout =  Console.ReadLine().ToUpper();
            if (checkout != "Y")
            {
              selected = "B";
            }
            Console.WriteLine("> THANK YOU FOR YOUR PURCHASE");
            Console.WriteLine("> Enter any key to leave");
            Console.ReadLine().ToUpper();
            makeOrder = "N";
          }

        }

        void breadLoop()
        {
          Console.Clear();
          Console.WriteLine("_________________________________");
          Console.WriteLine("////////////////////////////////|");
          Console.WriteLine("|                               |");
          Console.WriteLine("| How many loaves of BREAD      |");
          Console.WriteLine("|      would you like to ORDER? |");
          Console.WriteLine("|_______________________________|");
          Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~| \n");
          Console.WriteLine("> Enter number of loaves to add to cart.");
        }

        void breadCostLoop(int breadCost, int breadAmount)
        {
          Console.Clear();
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
          Console.Clear();
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