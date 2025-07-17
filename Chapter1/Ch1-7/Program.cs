using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 1-7輸入的西元年份轉換成民國年份後輸出
Console.Write("請輸入西元年 : ");
var year = Convert.ToInt32(Console.ReadLine());
var mingGo = year - 1911;

Console.WriteLine($"西元 {year} 為 民國 {mingGo} 年");