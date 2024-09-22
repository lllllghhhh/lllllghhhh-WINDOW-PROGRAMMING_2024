using System;

namespace Practice1_1
{
	internal class Program
	{
		static int balance = 10000;
		static bool ATM()
		{
			Console.WriteLine(
				"What do you want to do?\n(0)Check balance\n(1)Withdraw money\n(2)Deposit money\n(3)Transfer money\n(8) Exit");
			if (int.TryParse(Console.ReadLine(), out var option)) {
				switch (option) {
					case 0:
						Console.WriteLine("Balance : " + balance);
						break;
					case 1:
						Console.Write("Enter amount : ");
						var withdraw = int.Parse(Console.ReadLine());
						if (withdraw > 100000 | withdraw < 0) {
							Console.WriteLine("Exceed the valid amount 0 ~ 100000");
						}
						else {
							if (withdraw > balance) {
								Console.WriteLine("Exceed the existing amount");
							}
							else {
								Console.WriteLine("Successfully withdraw");
								balance -= withdraw;
								Console.WriteLine("Balance : " + balance);
							}
						}

						break;
					case 2:
						Console.Write("Enter amount : ");
						var deposit = int.Parse(Console.ReadLine());
						if (deposit > 100000 | deposit < 0) {
							Console.WriteLine("Exceed the valid amount 0 ~ 100000");
						}
						else {
							Console.WriteLine("Successfully withdraw");
							balance += deposit;
							Console.WriteLine("Balance : " + balance);
						}

						break;
					case 3:
						int account;
						Console.Write("Enter transfer account : ");
						if (int.TryParse(Console.ReadLine(), out account)) {
							Console.Write("Enter amount : ");
							var transfer = int.Parse(Console.ReadLine());
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
						else {
							Console.WriteLine("Account should be an integer");
						}

						break;
					case 8:
						return false;
					default:
						Console.WriteLine("There's no option");
						break;
				}
			}
			else {
				Console.WriteLine("Please enter a number");
			}

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