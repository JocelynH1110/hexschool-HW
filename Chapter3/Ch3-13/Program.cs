using System.Text;

Console.OutputEncoding = Encoding.UTF8;
// === 習題：3-6 寫一程式，輸入N個數字，求其所有正數之平方的加總 ===
// 例如輸入1,-2,3,-4,5五個數字，得到 12 + (-2)2 + 32 + (-4)2 + 52  = 1 + 9 + 25 = 35 

// for
/*
Console.Write("請輸入 n 個數字：");
double sum = 0;
double input= Convert.ToDouble(Console.ReadLine());
for (int i = 0; i < input; i++)
{
    Console.Write($"第 {i+1} 個值是： ");
    double num = Convert.ToDouble(Console.ReadLine());
    if (num > 0)
    {
        sum += Math.Pow(Math.Abs(num), 2);
    }
}
Console.WriteLine($"所有正整數平方加總為： {sum}");
*/

// while
Console.Write("請輸入 n 個數字：");
double input= Convert.ToDouble(Console.ReadLine());
double sum = 0;
int i = 0;
while (i < input)
{
    Console.Write($"第 {i+1} 個值是： ");
    double num = Convert.ToDouble(Console.ReadLine());
    if (num > 0)
    {
        sum += Math.Pow(Math.Abs(num), 2);
    }
    i++;
}
Console.WriteLine($"所有正整數平方加總為： {sum}");
