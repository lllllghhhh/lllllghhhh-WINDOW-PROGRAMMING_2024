using System;
using System.Collections.Generic;

namespace Practice2_2 {
	internal class Program {
		static Dictionary<string, int> item_list;
		
		static bool shop() {
			Console.WriteLine("======================================");
			Console.WriteLine("(1) 開店");
			Console.WriteLine("(2) 新增訂單");
			Console.WriteLine("(3) 查詢庫存");
			Console.WriteLine("(4) 查詢總收入");
			Console.WriteLine("(5) 計算人氣商品排名");
			Console.WriteLine("(6) 關店");
			Console.WriteLine("======================================");
			Console.Write("請輸入您現在想要進行的操作: ");
			if (int.TryParse(Console.ReadLine(), out var option)) {
				switch (option) {
					case 1:
						Console.Write("請輸入今日總共有幾種商品要販售: ");
						if (!int.TryParse(Console.ReadLine(), out var amount)) {
							Console.WriteLine("Please enter a number");
							break;
						}

						if (amount > 100 || amount < 1) {
							Console.WriteLine("Exceed the valid amount 1 ~ 100");
							break;
						}
						Console.Write("請依序輸入每一種商品的名稱: ");
						string[] item_list = Console.ReadLine().Split(' ');
						Console.Write("接下來，請你依序輸入每一個商品的價格: ");
						string[] pricel_list = Console.ReadLine().Split(' ');
						Console.Write("\n輸入完成! 每一種商品的價格依序為: \n");
						for (int i = 0; i < amount; i++) {
							Console.WriteLine($"{item_list[i]}: {pricel_list[i]}");
						}
						Console.WriteLine($"");

						

						
						


						break;
					case 2:
						break;
					case 3:
						break;
					case 4:
						break;
					case 5:
						break;
					case 6:
						break;
				}
			}
			else
				Console.WriteLine("Please enter a number");

			return true;
		}
		public static void Main(string[] args) {
			Console.WriteLine("歡迎來到 NCKU 卡比商店交易系統");
			
		}
	}
}