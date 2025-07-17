using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 日期：4.取得目前是幾月。
DateTime dt = DateTime.Today;
Console.WriteLine($"目前是 {dt.Month} 月");