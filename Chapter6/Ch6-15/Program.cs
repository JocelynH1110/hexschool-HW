using System.Numerics;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
// 正則式：題目二 : 寫一個function，回傳輸入的值是否數字

// write code here
Console.Write("請輸入一個值： ");
string input = Console.ReadLine();

bool result = Numbers.IsNumber(input);

if (result)
{
    Console.WriteLine($"您輸入的 {input} 是數字");
}
else
{
    Console.WriteLine($"您輸入的 {input} 不是數字");
}

// helper functions
public class Numbers
{
    public static bool IsNumber(string input)
    {
        return int.TryParse(input, out int result);
    }
}