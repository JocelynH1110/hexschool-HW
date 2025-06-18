using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("請輸入西元年 : ");
var year = Convert.ToInt32(Console.ReadLine());
var mingGo = year - 1911;

Console.WriteLine($"西元 {year} 為 民國 {mingGo} 年");