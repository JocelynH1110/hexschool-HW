using System.Net.Mime;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
// 正則式：題目六 : 寫一個function，若輸入的文字大於Ｎ個，則超過的字不要，變成點點點
Console.Write("請輸入一段字： ");
string s = Console.ReadLine();
Console.Write("輸入你要從第幾個字開始截斷： ");
int maxLength = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(InputText.CutText(s, maxLength));

public class InputText
{
    public static string CutText(string s, int maxLength)
    {
        if (string.IsNullOrEmpty(s) || maxLength <= 0)
        {
            return "";
        }

        if (s.Length <= maxLength)
        {
            return s;
        }
        else
        {
            return s.Substring(0, maxLength) + "...";
        }
    }
}