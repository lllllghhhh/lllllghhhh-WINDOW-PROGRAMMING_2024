using System;
using System.Collections.Generic;

namespace Practice1_2
{
  
  struct account
  {
    private int balance;
    account(int bal)
    {
      balance = bal;
    }
    static private Dictionary<int, account> AccountDict = new Dictionary<int, account>
    {
      {10000, new account(10000) },
      {11000, new account(10000) },
      {12000, new account(10000) },
      {13000, new account(10000) },
      {14000, new account(10000) },
      {15000, new account(10000) },
      {16000, new account(10000) },
      {17000, new account(10000) },
      {18000, new account(10000) },
      {19000, new account(10000) },
    };

    public void add_account(int n)
    {
      AccountDict.Add(n, new account(0));
    }
    public void print_balance()
    {
      Console.WriteLine("Balance : " + balance);
    }

    public void withdraw()
    {
      Console.Write("Enter amount : ");
      if (int.TryParse(Console.ReadLine(), out var withdraw)) {
        if (withdraw > 100000 | withdraw < 0) {
          Console.WriteLine("Exceed the valid amount 0 ~ 100000");
        }
        else {
          if (withdraw > balance) {
            Console.WriteLine("Exceed the existing amount");
          }
          else {
            Console.WriteLine("Successfully withdraw");
            balance -= withdraw ;
            Console.WriteLine("Balance : " + balance);
          }
        }
      }
      else 
        Console.WriteLine("Please enter a number");
    }

    public void deposit()
    {
      Console.Write("Enter amount : ");
      if (int.TryParse(Console.ReadLine(), out var deposit)) {
        if (deposit > 100000 | deposit < 0) {
          Console.WriteLine("Exceed the valid amount 0 ~ 100000");
        }
        else {
          Console.WriteLine("Successfully withdraw");
          balance += deposit;
          Console.WriteLine("Balance : " + balance);
        }
      }
      else
        Console.WriteLine("Please enter a number");
      
    }

    public void transfer()
    {
      Console.Write("Enter transfer account : ");
      if (int.TryParse(Console.ReadLine(), out var account)) {
        Console.Write("Enter amount : ");
        if (int.TryParse(Console.ReadLine(), out var transfer)) {
          if (transfer > 100000 | transfer < 0) {
            Console.WriteLine("Exceed the valid amount 0 ~ 100000");
          }
          else {
            if (transfer > balance) {
              Console.WriteLine("Exceed the existing amount");
            }
            else {

              Console.WriteLine("Final cost (+10%) = " + (int)(transfer * 1.1));
              Console.WriteLine("Successfully withdraw");
              balance -= (int)(transfer * 1.1);
              Console.WriteLine("Balance : " + balance);
            }
          }
        }
        else
          Console.WriteLine("Please enter a number");
      }
      else 
        Console.WriteLine("Account should be an integer");
    }
    
  }
  internal class Program
  {
    
    static bool ATM()
    {
      
      Console.WriteLine("Enter your account");
      if (int.TryParse(Console.ReadLine(), out var account_number)) {
        if (account_number.ToString().Length == 5) {
          account current_account = new account();
          current_account.add_account(account_number);
          while (true) {
            Console.WriteLine(
              "What do you want to do?\n(0)Check balance\n(1)Withdraw money\n(2)Deposit money\n(3)Transfer money\n(8) Exit");
            if (int.TryParse(Console.ReadLine(), out var option)) {
              switch (option) {
                case 0:
                  current_account.print_balance();
                  break;
                case 1:
                  current_account.withdraw();
                  break;
                case 2:
                  current_account.deposit();
                  break;
                case 3:
                  current_account.transfer();
                  break;
                case 8:
                  return false;
                default:
                  Console.WriteLine("There's no option");
                  break;
              }
            }
            else
              Console.WriteLine("Please enter a number");
          }
        }
        Console.WriteLine("Account should be five digits");
      }
      else 
        Console.WriteLine("Please enter a number");
      return true;
    }
    
    public static void Main(string[] args)
    {
      while (ATM())
        ;
    }
  }
}