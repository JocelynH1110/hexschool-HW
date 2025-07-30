using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 日期：5.取得明年是否為閏年。(可以試試民國)
var dt = DateTime.Today;

Console.Write(dt.IsLeapYear());

public static class DateTimeExtensions
{
    public static bool IsLeapYear(this DateTime dt)
    {
        DateTime nextYear=dt.AddYears(1);
        return nextYear.Year % 400 == 0 || (nextYear.Year % 4 == 0 && nextYear.Year % 100 != 0);
    }
}