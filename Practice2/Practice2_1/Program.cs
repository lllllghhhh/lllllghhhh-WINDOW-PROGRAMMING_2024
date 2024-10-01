using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice2_1 {
	internal class Program {
		private static string[] item_list;
		private static int[] price_list, amount_list, buying_list;
		private static List<int> rank_list = new List<int>();
		private static List<int> income_list = new List<int>();
		static Dictionary<string, int> rank = new Dictionary<string, int>();
		static bool shop() {
			Console.WriteLine("歡迎來到 NCKU 卡比商店交易系統");
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
						item_list = Console.ReadLine().Split(' ');
						if (item_list.Length != amount) {
							Console.WriteLine("Wrong amount!! Please enter again");
							Array.Clear(item_list, 0, item_list.Length);
							break;
						}
						
						Console.Write("接下來，請你依序輸入每一個商品的價格: ");
						var pricel_list = Console.ReadLine().Split(' ');
						price_list = Array.ConvertAll(pricel_list, int.Parse);
						if (pricel_list.Length != amount) {
							Console.WriteLine("Wrong amount!! Please enter again");
							Array.Clear(pricel_list, 0, item_list.Length);
							break;
						}
						Console.Write("\n輸入完成! 每一種商品的價格依序為: \n");
						for (int i = 0; i < amount; i++) {
							Console.WriteLine($"{item_list[i]}: {pricel_list[i]}");
						}
						Console.Write("\n最後，請你依序輸入每一個商品目前的庫存數量: ");
						var amountal_list = Console.ReadLine().Split(' ');
						amount_list= Array.ConvertAll(amountal_list, int.Parse);
						if (amount_list.Length != amount) {
							Console.WriteLine("Wrong amount!! Please enter again");
							Array.Clear(amount_list, 0, item_list.Length);
							break;
						}
						Console.Write("\n輸入完成! 每一種商品的庫存數量依序為: \n");
						for (int i = 0; i < amount; i++) {
							Console.WriteLine($"{item_list[i]}: {amount_list[i]}");
						}

						for (int i = 0; i < amount; i++) {
							rank_list.Add(0);
						}
						Console.WriteLine("\n開店程序完成，已開店\n");
						break;
					case 2:
						Console.Write("請依序輸入此訂單每一種類的商品各需要買幾個: ");
						var buyingal_list = Console.ReadLine().Split(' ');
						buying_list = Array.ConvertAll(buyingal_list, int.Parse);
						var total_price = 0;
						for (int i = 0; i < amount_list.Length; i++) {
							if (buying_list[i] - amount_list[i] > 0) {
								Console.WriteLine("\n庫存不足，此筆訂單不成立\n");
								return true;
							}

							total_price += buying_list[i] * price_list[i];
						}

						Console.Write($"\n訂單成立!，總金額為: {total_price}");
						Console.Write("請輸入消費者付款金額: ");
						bool run = false;
						bool money_bool = false;
						while(!money_bool){
							
							if (!int.TryParse(Console.ReadLine(), out var money)) {
								Console.WriteLine("Please enter a number");
								break;
							}
							
							if (money == -1 && run) {
								Console.WriteLine("訂單取消\n");
								return true;
							}

							run = true;
							
							if (total_price - money > 0) {
								Console.Write("\n付款金額不足，請再輸入一次 (或輸入 -1 直接取消此筆訂單): ");
								continue;
							}
							Console.Write($"\n付款完成! 請找零消費者共 {money - total_price} 元\n");
							income_list.Add(total_price);
							money_bool = true;
						}
						for (int i = 0; i < buying_list.Length; i++) {
							if(rank_list[i] > 0)
								rank_list[i] += buying_list[i];
							else
								rank_list[i] = buying_list[i];
							amount_list[i] -= buying_list[i];
						}
						break;
					case 3:
						bool amount_bool = false;
						for (int i = 0; i < amount_list.Length; i++) {
							Console.WriteLine($"{item_list[i]}: {amount_list[i]}");
							if (amount_list[i] <= 5)
								amount_bool = true;
						}
						if(amount_bool)
							Console.WriteLine("有商品的數量不足！！！");
						break;
					case 4:
						Console.WriteLine($"總收入為: {income_list.Sum()}");
						break;
					case 5:
						Console.WriteLine("人氣商品排行榜:");
						for (int i = 0; i < rank_list.Count ; i++) {
							if (rank.ContainsKey(item_list[i])) {
								rank[item_list[i]] = rank_list[i];
								continue;
							}
							rank.Add(item_list[i], rank_list[i]);
						}
						rank.OrderByDescending(d => d.Value).ToDictionary(n => n.Key, p => p.Value);
						int i_rank = 1;
						foreach (var VARIABLE in rank) {
							Console.WriteLine($"第 {i_rank++} 名: {VARIABLE.Key}, 總購買次數共 {VARIABLE.Value} 次");
						}
						break;
					case 6:
						return false;
				}
			}
			else
				Console.WriteLine("Please enter a number");

			return true;
		}
		public static void Main(string[] args) {
			while (shop()) {
				;
			}
			
		}
	}
}