using System.Text;

Console.OutputEncoding = Encoding.UTF8;
// 日期：2.顯示再過30天為哪一天。
DateTime dt = DateTime.Today;
DateTime day = dt.AddDays(30);

Console.WriteLine($"{day.Month}月{day.Day}日");