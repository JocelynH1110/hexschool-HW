using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 日期：6.取得離2025年1月1日還有幾天。
DateTime dt = DateTime.Now;
DateTime someday = new DateTime(2025, 1, 1);

int dif = (int)(someday - dt).TotalDays;
Console.WriteLine($"現在是 {dt:yyyy年MM月dd日}，距離 {someday:yyyy年MM月dd日} 還有 {dif} 天");