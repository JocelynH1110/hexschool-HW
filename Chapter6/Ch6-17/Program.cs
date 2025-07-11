using System.Text;
using System.Text.RegularExpressions;

Console.OutputEncoding = Encoding.UTF8;
// 正則式：題目四 : 寫一個function，回傳輸入的值是否符合手機格式
Console.Write("請輸入手機號碼： ");
string number = Console.ReadLine();
Console.WriteLine(Phone.IsVaildPhoneNum(number));

public class Phone
{
    public static string IsVaildPhoneNum(string number)
    {
        string pattern = @"^0\d{9}";
        Regex numcheck = new Regex(pattern);
        if (numcheck.IsMatch(number))
        {
            return "符合手機號碼格式";
        }
        else
        {
            return "不符合手機號碼格式";
        }
    }
}