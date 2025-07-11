using System.Globalization;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
// 正則式：題目八 : 寫一個function，輸入一個日期，把該日期轉成民國XX年XX月XX日 星期X 格式

Console.Write("請輸入一個日期： ");
string date = Console.ReadLine();
if (string.IsNullOrEmpty(date)) return;
DateTime dt = DateTime.Parse(date);
Console.WriteLine(DateHelpers.ToROCDate(dt));

public class DateHelpers
{
    public static string ToROCDate(DateTime dt)
    {
        var culture = new CultureInfo("zh-TW");
        var dayOfWeek = dt.ToString("dddd", culture);
        return $"民國{dt.Year - 1911}年.{dt:MM}月.{dt:dd}日 {dayOfWeek}";
    }
}