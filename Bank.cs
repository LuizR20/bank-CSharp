using System;

public class Bank
{
  public static void Main (string[] args)
  {
    int money = 1000;
    
    Console.WriteLine("=== Bank ===");
    Console.WriteLine();
    
    Console.WriteLine("Welcome to the bank! What you gonna do now?");
    Console.WriteLine($"Money: {money}");
    Console.WriteLine();
    
    bool running = true;
    while (running)
    {
      Console.Clear();
      
      Console.WriteLine("1. Deposit");
      Console.WriteLine();
    
      Console.WriteLine("2. Withdraw");
      Console.WriteLine();
    
      Console.WriteLine("3. Balance");
      Console.WriteLine();
    
      Console.WriteLine("4. Exit");
      Console.WriteLine();
    
      Console.WriteLine("Please, enter your option.");
      Console.WriteLine();
    
      string option = Console.ReadLine();
      switch (option)
      {
        case "1":
        
        Console.WriteLine();
        Console.WriteLine("Ok, let's go! How much do you want to deposit?");
        string inputdeposit = Console.ReadLine();
        int deposit;
        
        if (int.TryParse(inputdeposit, out deposit) && deposit > 0)
        {
          money += deposit;
          Console.WriteLine();
          Console.WriteLine("The deposit has been completed!");
          Console.WriteLine($"Current balance: {money:C}");
        }
        else
        {
          Console.WriteLine();
          Console.WriteLine("Sorry, enter a positive number to deposit in your balance.");
        }
        break;
        
        case "2":
        
        Console.WriteLine();
        Console.WriteLine("Here we go! How much do you want to withdraw?");
        string inputwithdraw = Console.ReadLine();
        int withdraw;
        
        if (int.TryParse(inputwithdraw, out withdraw) && withdraw <= money)
        {
          money -= withdraw;
          Console.WriteLine();
          Console.WriteLine("The withdraw has been completed!");
          Console.WriteLine($"Current balance: {money:C}");
        }
        else
        {
          Console.WriteLine();
          Console.WriteLine("Sorry, your balance is lower than the withdraw amount.");
        }
        
        break;
        
        case "3":
        
        Console.WriteLine();
        Console.WriteLine($"Your current balance: {money:C}");
        break;
        
        case "4":
        
        Console.WriteLine();
        Console.WriteLine("Have a good day and see you later!");
        running = false;
        break;
        
        default:
        
        Console.WriteLine();
        Console.WriteLine("We don't understand your answer... Please, try again.");
        break;
      }
    }
  }
}