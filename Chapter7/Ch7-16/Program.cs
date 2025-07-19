using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 日期：5.取得明年是否為閏年。(可以試試民國)
var dt = DateTime.Today;

Console.Write(dt.IsLeapYear());

public static class DateTimeExtensions
{
    public static bool IsLeapYear(this DateTime dt)
    {
        return dt.Year % 400 == 0 || (dt.Year % 4 == 0 && dt.Year % 100 != 0);
    }
}