using System.Text;

Console.OutputEncoding = Encoding.UTF8;
// 字串補充練習：
// 5.輸入5處數字，用空白隔開，輸出結果。
// 例如：輸入‘11 19 12 25 1 7 12，輸出總和是87
Console.Write("輸入數字：");
var input = Console.ReadLine();
var arr = input.Split(" ");
var sum = 0;
foreach (var num in arr)
{
    sum += Convert.ToInt32(num);
}

Console.WriteLine($"數字總和為：{sum}");