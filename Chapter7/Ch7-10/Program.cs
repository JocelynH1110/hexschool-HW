using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 亂數：補充 2.請在文字檔裡輸入所有午餐的店家，讀取文字檔，隨機抽出今天中午要吃哪一家。
string[] stores = new string[] { "Q比", "7-11", "阿婆便當", "吃土" };
File.WriteAllLines("lunchShops.txt", stores);

Random r = new Random();
Console.WriteLine(stores[r.Next(stores.Length)]);