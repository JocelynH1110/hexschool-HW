using System.Text;

Console.OutputEncoding = Encoding.UTF8;
// 正則式：題目七： 寫一個function，輸入一個日期，把該日期轉成民國年.月.日格式

Console.Write("請輸入一個日期： ");
string date = Console.ReadLine();
if (string.IsNullOrEmpty(date)) return;
DateTime dt = DateTime.Parse(date);
Console.WriteLine(DateHelpers.ToROCDate(dt));

public class DateHelpers
{
    public static string ToROCDate(DateTime dt)
    {
        return $"民國{dt.Year - 1911}年.{dt.Month}月.{dt.Day}日";
    }
}