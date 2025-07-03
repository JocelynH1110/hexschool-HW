using System.Diagnostics.CodeAnalysis;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 例題4.3 計算N個數字的和。
// 檢查i有沒有超過N，超過就不做了。
Console.Write("輸入 n 個數字： ");
int input=Convert.ToInt32(Console.ReadLine());
int i = 0;
int sum = 0;
while (i<input)
{
    Console.Write($"第 {i+1} 個數字為：");
    int num = Convert.ToInt32(Console.ReadLine());
    sum += num;
    i++;
}
Console.WriteLine(sum);