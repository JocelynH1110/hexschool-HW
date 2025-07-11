using System.Text;
using System.Text.RegularExpressions;

Console.OutputEncoding = Encoding.UTF8;
// 正則式：題目五 : 寫一個function，回傳輸入的值是否符合身分證字號格式
Console.Write("請輸入身份證字號： ");
string id = Console.ReadLine();
Console.WriteLine(Id.IdCheck(id));

public class Id
{
    public static string IdCheck(string id)
    {
        string patten = @"^[a-zA-Z][12]\d{8}";
        Regex idcheck = new Regex(patten);

        if (idcheck.IsMatch(id))
        {
            return "您所輸入的值，符合身份證格式";
        }
        else
        {
            return "您所輸入的值，不符合身份證格式";
        }
    }
}