using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 正則式：題目一 : 寫一個function 可以把一般對話框的文字轉成HTML。
Console.Write("請輸入您的對話： ");
Console.WriteLine(Helpers.ConvertToHtml(Console.ReadLine() ?? ""));

public class Helpers
{
    public static string ConvertToHtml(string t)
    {
        if (string.IsNullOrEmpty(t))
        {
            return "";
        }

        return t.Replace("&", "&amp;")
            .Replace("<", "&lt;")
            .Replace(">", "&gt;")
            .Replace("\"", "&quot;")
            .Replace("\n", "<br/>");
    }
}