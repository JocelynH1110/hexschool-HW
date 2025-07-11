using System.Text;

Console.OutputEncoding = Encoding.UTF8;
// 正則式：題目九 : 寫一個function，回傳輸入的年是否閏年
Console.Write("輸入一個年份： ");
int year = Convert.ToInt32(Console.ReadLine());

if (LeapYear.IsLeapYear(year))
{
    Console.WriteLine($"您輸入的 {year}年 是閏年");
}
else
{
    Console.WriteLine($"您輸入的 {year} 不是閏年");
}

class LeapYear
{
    public static bool IsLeapYear(int year)
    {
        return ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0));
    }
}