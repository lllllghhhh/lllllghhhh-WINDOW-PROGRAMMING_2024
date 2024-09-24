using System;

namespace Practice1_1
{
	internal class Program
	{
		static int balance = 10000;
		static bool ATM()
		{
			Console.WriteLine(
				"What do you want to do?\n\t(0)Check balance\n\t(1)Withdraw money\n\t" +
				"(2)Deposit money\n\t(3)Transfer money\n\t(8) Exit");
			if (int.TryParse(Console.ReadLine(), out var option)) {
				switch (option) {
					case 0:
						Console.WriteLine("Balance : " + balance);
						break;
					case 1:
						Console.Write("Enter amount : ");
						if (!int.TryParse(Console.ReadLine(), out var withdraw)) {
							Console.WriteLine("Please enter a number");
							break;
						}
						if (withdraw > 100000 || withdraw < 0) {
							Console.WriteLine("Exceed the valid amount 0 ~ 100000");
							break;
						}
						if (withdraw > balance) {
							Console.WriteLine("Exceed the existing amount");
							break;
						}
						Console.WriteLine("Successfully withdraw");
						balance -= withdraw;
						Console.WriteLine("Balance : " + balance);
						break;
					case 2:
						Console.Write("Enter amount : ");
						if (!int.TryParse(Console.ReadLine(), out var deposit)) {
							Console.WriteLine("Please enter a number");
							break;
						}
						if (deposit > 100000 || deposit < 0) {
							Console.WriteLine("Exceed the valid amount 0 ~ 100000");
							break;
						}
						Console.WriteLine("Successfully withdraw");
						balance += deposit;
						Console.WriteLine("Balance : " + balance);
						break;
					case 3:
						Console.Write("Enter transfer account : ");
						if (!int.TryParse(Console.ReadLine(), out var account)) {
							Console.WriteLine("Account should be an integer");
							break;
						}
						Console.Write("Enter amount : ");
						if (!int.TryParse(Console.ReadLine(), out var transfer)) {
							Console.WriteLine("Please enter a number"); 
						}
						if (transfer > 100000 || transfer < 0) {
							Console.WriteLine("Exceed the valid amount 0 ~ 100000");
							break;
						}
						if ((int)(transfer * 1.1) > balance) {
							Console.WriteLine("Exceed the existing amount");
							break;
						}
						Console.WriteLine("Final cost (+10%) = " + (int)(transfer * 1.1));
						Console.WriteLine("Successfully withdraw");
						balance -= (int)(transfer * 1.1);
						Console.WriteLine("Balance : " + balance);
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
			return true;
		}

		public static void Main(string[] args)
		{
			Console.WriteLine("Welcome to NiCKU ATM\n");
			while (ATM())
				;
		}

		}
	}