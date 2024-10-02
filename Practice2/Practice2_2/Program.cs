using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Practice2_2 {
	internal class Program {
		static Random rnd = new Random();
		static bool open;
		private static List<string> item_list = new List<string>();
		private static List<int> price_list = new List<int>(), amount_list = new List<int>(), rank_list = new List<int>();
		private static List<int> income_list = new List<int>();
		
		private static Dictionary<string, List<int>> purchase_history = new Dictionary<string, List<int>>();
		
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
						while (true) {
							Console.Write("請輸入今日總共有幾種商品要販售: ");
							if (!int.TryParse(Console.ReadLine(), out var amount)) {
								Console.WriteLine("Please enter a number");
								continue;
							}

							if (amount > 100 || amount < 1) {
								Console.WriteLine("Exceed the valid amount 1 ~ 100");
								continue;
							}
							Console.Write("請依序輸入每一種商品的名稱: ");
							var itemNames = Console.ReadLine()?.Split(' ');
							if (itemNames == null || itemNames.Length != amount) {
								Console.WriteLine("錯誤，請重新輸入");
								continue;
							}
							item_list.AddRange(itemNames);

							Console.Write("接下來，請你依序輸入每一個商品的價格: ");
							try {
								var priceList = Console.ReadLine()?.Split(' ').Select(uint.Parse).ToList();
								if (priceList == null || priceList.Count != amount) {
									Console.WriteLine("錯誤，請重新輸入");
									continue;
								}
								price_list.AddRange(priceList.Select(i => (int)i));
							} catch {
								Console.WriteLine("錯誤，請重新輸入");
								continue;
							}
							Console.Write("\n輸入完成! 每一種商品的價格依序為: \n");
							for (var i = 0; i < amount; i++) {
								Console.WriteLine($"{item_list[i]}: {price_list[i]}");
							}
							
							Console.Write("\n最後，請你依序輸入每一個商品目前的庫存數量: ");
							try {
								var list = Console.ReadLine()?.Split(' ').Select(uint.Parse).ToList();
								if (list == null || list.Count != amount) {
									Console.WriteLine("錯誤，請重新輸入");
									continue;
								}
								amount_list.AddRange(list.Select(i => (int)i));
							} catch {
								Console.WriteLine("錯誤，請重新輸入");
								continue;
							}
							Console.Write("\n輸入完成! 每一種商品的庫存數量依序為: \n");
							for (int i = 0; i < amount; i++) {
								Console.WriteLine($"{item_list[i]}: {amount_list[i]}");
							}

							rank_list.AddRange(Enumerable.Repeat(0, amount));

							open = true;
							Console.WriteLine("\n開店程序完成，已開店\n");
							break;
						}
						break;
					case 2 when open:
						List<int> buying_list;
						Console.Write("請依序輸入此訂單每一種類的商品各需要買幾個: ");
						for (var run = false; ; run = true) {
							buying_list = Console.ReadLine()?.Split(' ').Select(int.Parse).ToList();
							if (buying_list == null || buying_list.Count != amount_list.Count) {
								Console.Write("請使用者重新輸入，或是直接輸入一個 -1 取消訂單: ");
								continue;
							}
							if (run && buying_list[0] == -1) {
								Console.WriteLine("訂單取消\n");
								return true;
							}
							if (buying_list.Any(x => x < 0)) {
								Console.Write("請使用者重新輸入，或是直接輸入一個 -1 取消訂單: ");
								continue;
							}
							break;
						}

						var total_price = 0;
						for (int i = 0; i < amount_list.Count; i++) {
							if (buying_list[i] > amount_list[i]) {
								Console.WriteLine("\n庫存不足，此筆訂單不成立\n");
								return true;
							}

							total_price += buying_list[i] * price_list[i];
						}

						
						Console.Write($"\n訂單成立!，總金額為: {total_price}");
						if (total_price >= 1000) {
							var discount = rnd.Next(1, 10);
							total_price *= discount / 10;
							Console.Write($"因訂單滿 1000 元，因此總金額打 {discount} 折。打折後為 {total_price} 元 ");
						}
						Console.Write("請輸入消費者付款金額: ");
						
						for (var run = false; ; run = true) {
							
							if (!int.TryParse(Console.ReadLine(), out var money)) {
								Console.Write("請輸入正整數！！(或輸入 -1 直接取消此筆訂單): ");
								continue;
							}
							if (run && money == -1) {
								Console.WriteLine("訂單取消\n");
								return true;
							}
							if (money < 0) {
								Console.Write("請輸入正整數！！(或輸入 -1 直接取消此筆訂單): ");
								continue;
							}
							if (total_price - money > 0) {
								Console.Write("\n付款金額不足，請再輸入一次 (或輸入 -1 直接取消此筆訂單): ");
								continue;
							}
							Console.Write($"\n付款完成! 請找零消費者共 {money - total_price} 元\n");
							
							income_list.Add(total_price);
							break;
						}

						var nameTest = new Regex("^[A-Za-z]+(?: +[A-Za-z]+)+$");
						string name;
						while (true) {
							Console.Write("請輸入消費者的名字: ");
							name = Console.ReadLine();
							if (name != null && nameTest.IsMatch(name))
								break;
							Console.WriteLine("輸入錯誤！");
						}
						if (purchase_history.TryGetValue(name, out var sorted))
							sorted.Add(total_price);
						else {
							purchase_history.Add(name, new List<int>{ 0, 0, total_price });
						}

						var history = purchase_history[name];
						Console.WriteLine($"消費者{name}歷史資訊\n");
						Console.WriteLine($"此消費者歷史訂單中，最大金額為: {history.Max()} 元");
						int r = 0;
						foreach (var v in Enumerable.Reverse(history).Take(3)) {
							Console.WriteLine($"近期消費 {++r}: {v}");
						}
						for (int i = 0; i < buying_list.Count; i++) {
							rank_list[i] += buying_list[i];
							amount_list[i] -= buying_list[i];
						}
						break;
					case 3 when open:
						var outOfStockWarning = false;
						for (var i = 0; i < amount_list.Count; i++) {
							Console.WriteLine($"{item_list[i]}: {amount_list[i]}");
							if (amount_list[i] <= 5)
								outOfStockWarning = true;
						}
						if(outOfStockWarning)
							Console.WriteLine("有商品的數量不足！！！");
						break;
					case 4 when open:
						Console.WriteLine($"總收入為: {income_list.Sum()}");
						break;
					case 5 when open:
						Console.WriteLine("人氣商品排行榜:");
						var i_rank = 0;
						foreach (var (index, v) in rank_list.Select((v, index) => (index, v)).OrderByDescending(p => p.v))
							Console.WriteLine($"第 {++i_rank} 名: {item_list[index]}, 總購買次數共 {v} 次");
						break;
					case 6 when open:
						return false;
					default:
						if (!open && 2 <= option && option <= 6) {
							Console.WriteLine("尚未開店，請重新輸入！！");
							return true;
						}
						Console.WriteLine("無此功能，請重新輸入！！");
						break;
				}
			}
			else
				Console.WriteLine("請輸入數字");

			return true;
		}
		public static void Main(string[] args) {
			while (shop()) {
				;
			}
			
		}
	}
}