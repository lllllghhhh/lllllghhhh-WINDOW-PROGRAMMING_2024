using System;
using System.Collections.Generic;

namespace Practice1_2 {
	class account {
	
		private int balance;
		private int points;

		account(int bal, int poi) {
			balance = bal;
			points = poi;
		}

		public static Dictionary<int, account> AccountDict = new Dictionary<int, account>
		{
			{ 10000, new account(10000, 0) },
			{ 11000, new account(10000, 0) },
			{ 12000, new account(10000, 0) },
			{ 13000, new account(10000, 0) },
			{ 14000, new account(10000, 0) },
			{ 15000, new account(10000, 0) },
			{ 16000, new account(10000, 0) },
			{ 17000, new account(10000, 0) },
			{ 18000, new account(10000, 0) },
			{ 19000, new account(10000, 0) },
		};

		private List<(int, int)> historyList = new List<(int, int)>();

		public static account add_account(int n, int init_balance) {
			var new_acc = new account(init_balance, 0);
			AccountDict.Add(n, new_acc);
			return new_acc;
		}

		public void print_balance() {
			Console.WriteLine($"Balance : {balance}");
		}

		public void withdraw() {
			Console.Write("Enter amount : ");
			if (int.TryParse(Console.ReadLine(), out var withdraw)) {
				if (withdraw > 100000 || withdraw < 0) {
					Console.WriteLine("Exceed the valid amount 0 ~ 100000");
					return;
				}
				if (withdraw > balance) {
					Console.WriteLine("Exceed the existing amount");
					return;
				}
				balance -= withdraw;
				historyList.Add((1, balance));
				Console.WriteLine("Successfully withdraw");
				Console.WriteLine($"Balance : {balance}");
			}
			else
				Console.WriteLine("Please enter a number");
		}

		public void deposit()
		{
			Console.Write("Enter amount : ");
			if (!int.TryParse(Console.ReadLine(), out var deposit)) {
				Console.WriteLine("Please enter a number");
				return;
			}
			if (deposit > 100000 || deposit < 0) {
				Console.WriteLine("Exceed the valid amount 0 ~ 100000");
				return;
			}
			balance += deposit;
			historyList.Add((2, balance));
			Console.WriteLine($"Balance : {balance}");
		}

		public void transfer() {
			Console.Write("Enter transfer account : ");
			var input = Console.ReadLine();
			if (input == null || !int.TryParse(input, out var target_account)) {
				Console.WriteLine("Account should be an integer");
				return;
			}
			if (input.Length != 5) {
				Console.WriteLine("Account should be five digits");
				return;
			}
			if (!AccountDict.ContainsKey(target_account)) {
				Console.WriteLine(
					"This is not a exist account, press 1 if you want to open one and keep going");
				if (Console.ReadLine() == "1")
					add_account(target_account, 0);
				else
					return;
			} else if (ReferenceEquals(AccountDict[target_account], this)) {
				Console.WriteLine("You can't transfer to yourself");
				return;
			}
			Console.Write("Enter amount : ");
			if (!int.TryParse(Console.ReadLine(), out var transfer)) {
				Console.WriteLine("Please enter a number");
				return;
			}
			if (transfer > 100000 || transfer < 0) {
				Console.WriteLine("Exceed the valid amount 0 ~ 100000");
				return;
			}
			if (transfer > balance) {
				Console.WriteLine("Exceed the existing amount");
				return;
			}
			var discounted = false;
			if (points > 0) {
				Console.WriteLine($"You have {points} point, do you want use 1 point to save handling fee?" +
				                  "\n\tPress 1 if tou want to use");
				if (Console.ReadLine() == "1") {
					discounted = true;
					--points;
					Console.WriteLine($"Final cost (+0%) = {transfer}");
					balance -= transfer;
					AccountDict[target_account].balance += transfer;
				}
			}
			if (!discounted) {
				if ((int)(transfer * 1.1) > balance) {
					Console.WriteLine("Exceed the existing amount");
					return;
				}
				Console.WriteLine($"Final cost (+10%) = {(int)(transfer * 1.1)}");
				balance -= (int)(transfer * 1.1);
				AccountDict[target_account].balance += transfer;
			}
			Console.WriteLine("Successfully withdraw");
			historyList.Add((3, balance));
			Console.WriteLine($"Balance : {balance}");
		}

		public void donate() {
			Console.Write("Enter amount : ");
			if (!int.TryParse(Console.ReadLine(), out var donate)) {
				Console.WriteLine("Please enter a number");
				return;
			}
			if (donate > 100000 || donate < 0) {
				Console.WriteLine("Exceed the valid amount 0 ~ 100000");
				return;
			}
			if (donate > balance) {
				Console.WriteLine("Exceed the existing amount");
				return;
			}
			Console.WriteLine("Successfully withdraw");
			balance -= donate;
			points += donate / 1000;
			historyList.Add((4, balance));
			Console.WriteLine($"Balance : {balance}");
		}

		public void history_print()
		{
			Console.WriteLine("transaction history");
			foreach (var entry in historyList) {
				Console.WriteLine($"\t{entry.Item1} - {entry.Item2}");
			}
		}

		public static void account_print() {
			Console.WriteLine("Welcome to the backend system\n" +
			                  "Below are the existing accounts and their balances");
			foreach (var dict in AccountDict) {
				Console.WriteLine($"\tAccount : {dict.Key} - {dict.Value.balance}");
			}
		}
	}

	internal class Program
	{
		static bool ATM()
		{
			Console.WriteLine("Enter your account");
			if (!int.TryParse(Console.ReadLine(), out var account_number)) {
				Console.WriteLine("Please enter a number");
				return true;
			}
			if (account_number.ToString().Length != 5) {
				Console.WriteLine("Account should be five digits");
				return true;
			}

			if (account.AccountDict.ContainsKey(account_number)) {
				Console.WriteLine("Already have this account, please try another one");
				return true;
			}
			var current_account = account.add_account(account_number, 10000);
			while (true) {
				Console.WriteLine(
					"\nWhat do you want to do?\n\t(0)Check balance\n\t(1)Withdraw money\n\t(2)Deposit money\n\t" +
					"(3)Transfer money\n\t(4)Donate\n\t(5)History\n\t(8)Exit");
				if (!int.TryParse(Console.ReadLine(), out var option)) {
					Console.WriteLine("Please enter a number");
					continue;
				}
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
					case 4:
						current_account.donate();
						break;
					case 5:
						current_account.history_print();
						break;
					case 65304:
						account.account_print();
						break;
					case 8:
						return false;
					default:
						Console.WriteLine("There's no option");
						break;
				}
			}
		}

		public static void Main(string[] args) {
			Console.WriteLine("Welcome to NiCKU ATM");
			while (ATM())
				;
		}
	}
}