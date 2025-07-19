using System.Globalization;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 日期：補充 1.
// 星期一，猴子穿新衣，
// 星期二，猴子肚子餓，
// 星期三，猴子去爬山，
// 星期四，猴子看電視，
// 呈期五，猴子去跳舞，
// 星期六，猴子去斗六，
// 星期日，猴子過生日。
// 請顯示今天猴子做甚麼事。

DateTime dt = DateTime.Today;
Console.WriteLine(Datehelper.MonkeyDay(dt));

public class Datehelper
{
    public static string MonkeyDay(DateTime dt)
    {
        return dt.DayOfWeek switch
        {
            DayOfWeek.Monday => "星期一猴子穿新衣",
            DayOfWeek.Tuesday => "星期二猴子肚子餓",
            DayOfWeek.Wednesday => "星期三猴子去爬山",
            DayOfWeek.Thursday => "星期四猴子看電視",
            DayOfWeek.Friday => "呈期五猴子去跳舞",
            DayOfWeek.Saturday => "星期六猴子去斗六",
            DayOfWeek.Sunday => "星期日猴子過生日"
        };
    }
}