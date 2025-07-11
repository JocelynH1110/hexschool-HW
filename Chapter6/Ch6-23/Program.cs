using System.Text;
using System.Text.RegularExpressions;

Console.OutputEncoding = Encoding.UTF8;
// 正則式：題目十 : 寫一個function，輸入手機號碼，回傳今天運勢
// (手機運勢算法：用你的手機號碼的最後四位數除以80，再減去整數部分（只留小數），再乘以80，就會得到一個數，這就是代表吉凶的數字，印出結果。)
// https://kknews.cc/zh-tw/astrology/l26rzyb.html
Console.Write("請輸入手機末四碼: ");
var input = Console.ReadLine();
if (string.IsNullOrEmpty(input) || new Regex(@"^\d{4}$").IsMatch(input)) return;
var number = Fortune.PhoneNum(input);
Console.WriteLine(Fortune.Prediction(number));

internal static partial class Fortune
{
    public static string Prediction(int number)
    {
        return number switch
        {
            1 => "大展鴻圖．可獲成功　吉",
            2 => "一盛一衰．勞而無功　凶",
            3 => "蒸蒸日上．百事順遂　吉",
            4 => "坎坷前途．苦難折磨　凶",
            5 => "生意欣榮．名利雙收　吉",
            _ => "天降幸運．可成大功　吉"
        };
    }

    public static int PhoneNum(string phoneNumber)
    {
        int asInt = Convert.ToInt32(phoneNumber);
        return (int)((asInt / 80.0 - Math.Floor(asInt / 80.0)) * 80);
    }
}