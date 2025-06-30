using System.Text;

Console.OutputEncoding = Encoding.UTF8;
// === 習題：3-2.寫一程式，輸入 n 個整數，求其最小值 ===
// while
/*
Console.WriteLine("請輸入 n 個整數");
int input=Convert.ToInt32(Console.ReadLine());
int min=int.MaxValue;
int i = 0;
while (i < input)
{
    Console.Write($"第 {i+1} 個整數為：");
    int num = Convert.ToInt32(Console.ReadLine());
        if (num < min)
        {
            min= num;
        }
    i++;
}
Console.WriteLine($"最小值為 ：{min}");
*/

// for
Console.WriteLine("請輸入 n 個整數");
int input=Convert.ToInt32(Console.ReadLine());
int min=int.MaxValue;
for (int i = 0; i < input; i++)
{
    Console.Write($"第 {i+1} 個整數為：");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num < min)
    {
        min= num;
    }
}
Console.WriteLine($"最小值為 ：{min}");
