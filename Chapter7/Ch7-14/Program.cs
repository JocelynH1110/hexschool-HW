using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 日期：3.顯示24小時前的年月日時分秒。
DateTime dt = DateTime.Now;
DateTime last = dt.AddHours(-24);

Console.WriteLine($"24 小時前為：\n{last:yyyy年MM月dd日hh時mm分ss秒}");