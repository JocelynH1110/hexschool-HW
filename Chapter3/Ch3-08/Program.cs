using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// === 習題：3-1.寫一程式，輸入 10 個整數，求其最小值 ===
// while
Console.WriteLine("請輸入 10 個整數");
int min=int.MaxValue;
int i = 0;
while (i < 10)
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

// for
/*
Console.WriteLine("請輸入 10 個整數");
int min=int.MaxValue;
for (int i = 0; i < 10; i++)
{
    Console.Write($"第 {i+1} 個整數為：");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num < min)
    {
        min= num;
    }
}
Console.WriteLine($"最小值為 ：{min}");
*/