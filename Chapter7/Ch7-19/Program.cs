using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 日期：補充 2.輸入兩個日期，輸出兩個日期相差幾天。
Console.Write("請輸入第一個日期： ");
DateTime date1 = Convert.ToDateTime(Console.ReadLine());
Console.Write("請輸入第二個日期： ");
DateTime date2 = Convert.ToDateTime(Console.ReadLine());
int between = (int)(date2 - date1).TotalDays;

Console.WriteLine($"\n第一個日期 {date1:yyyy 年 MM 月 dd 日} 和第二個日期 {date2:yyyy 年 MM 月 dd 日}\n差 {between} 天");