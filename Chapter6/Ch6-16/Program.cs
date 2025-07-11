using System.Text;
using System.Text.RegularExpressions;

Console.OutputEncoding = Encoding.UTF8;
// 正則式：題目三 : 寫一個function，回傳輸入的值是否符合Ｅ－ｍａｉｌ格式
Console.Write("請輸入您的 E-mail： ");
string email = Console.ReadLine();
Console.WriteLine(Email.IsEmailFormat(email));

public class Email
{
    public static string IsEmailFormat(string email)
    {
        string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-+\.[a-zA-Z0-9-.]+$";
        Regex emailcheck = new Regex(pattern);

        if (emailcheck.IsMatch(email))
        {
            return "輸入的值符合 E-mail 格式";
        }
        else
        {
            return "輸入的值不符合 E-mail 格式";
        }
    }
}