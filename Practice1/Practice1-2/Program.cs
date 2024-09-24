using System;
using System.Collections.Generic;

namespace Practice1_2
{
  
  struct account
  {
    private int balance;
    private int points;
    account(int bal, int poi)
    {
      balance = bal;
      points = poi;
    }
    static private Dictionary<int, account> AccountDict = new Dictionary<int, account>
    {
      {10000, new account(10000,0) },
      {11000, new account(10000,0) },
      {12000, new account(10000,0) },
      {13000, new account(10000,0) },
      {14000, new account(10000,0) },
      {15000, new account(10000,0) },
      {16000, new account(10000,0) },
      {17000, new account(10000,0) },
      {18000, new account(10000,0) },
      {19000, new account(10000,0) },
    };

    static private List<(int, int)> historyList = new List<(int, int)>
    {
      
    };

    public void add_account(int n)
    {
      AccountDict.Add(n, new account(0,0));
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
            historyList.Add((1,balance));
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
          historyList.Add((2, balance));
          Console.WriteLine("Balance : " + balance);
        }
      }
      else
        Console.WriteLine("Please enter a number");
      
    }

    private void transfer_0(int acc)
    {
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
            historyList.Add((3, balance));
            Console.WriteLine("Balance : " + balance);
          }
        }
      }
      else
        Console.WriteLine("Please enter a number");
    }

    public void transfer(int acc_num)
    {
      Console.Write("Enter transfer account : ");
      if (int.TryParse(Console.ReadLine(), out var account)) {
        if (account.ToString().Length == 5) {
          if (account == acc_num) {
            Console.WriteLine("You can't transfer to yourself");
          }
          else if (AccountDict.ContainsKey(account)) {
            
          }
          else {
            Console.WriteLine("This is not a exist account, press 1 if you want to open one and keep going");
            if (Console.ReadLine() == "1") {
              transfer_0(account);

            }
          }
        }
        else 
          Console.WriteLine("Account should be five digits");
      }
      else 
        Console.WriteLine("Account should be an integer");
    }

    public void donate()
    {
      Console.Write("Enter amount : ");
      if (int.TryParse(Console.ReadLine(), out var donate)) {
        if (donate > 100000 | donate < 0) {
          Console.WriteLine("Exceed the valid amount 0 ~ 100000");
        }
        else {
          if (donate > balance) {
            Console.WriteLine("Exceed the existing amount");
          }
          else {
            Console.WriteLine("Successfully withdraw");
            balance -= donate;
            points += donate / 1000;
            historyList.Add((4, balance));
            Console.WriteLine("Balance : " + balance);
          }
        }
      }
      else
        Console.WriteLine("Please enter a number");

    }

    public void history_print()
    {
      Console.WriteLine("transaction history");
      foreach (var entry in historyList) {
        Console.WriteLine("{0} - {1}", entry.Item1,entry.Item2);
      }
    }

    public void account_print()
    {
      Console.WriteLine("Welcome to the backend system\n" +
                        "Below are the existing accounts and their balances");
      foreach (var dict in AccountDict) {
        Console.WriteLine("Account : {0} - {1}", dict.Key, dict.Value.balance);
      }
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
              "What do you want to do?\n\t(0)Check balance\n\t(1)Withdraw money\n\t(2)Deposit money\n\t" +
              "(3)Transfer money\n\t(4)Donate\n\t(5)History\n\t(8) Exit");
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
                  current_account.transfer(account_number);
                  break;
                case 4:
                  current_account.donate();
                  break;
                case 5:
                  current_account.history_print();
                  break;
                case 65304:
                  current_account.account_print();
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