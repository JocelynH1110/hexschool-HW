using System.Text;

Console.OutputEncoding = Encoding.UTF8;
// === 習題：3-5 寫一程式，輸入N個數字，求其所有奇數中的最大值。
// 例如輸入11,12,3,24,15，答案是15。===

// for
Console.Write("請輸入 n 個數字：");
int max = int.MinValue;
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < num; i++)
{
    Console.Write($"輸入第 {i+1} 個數字：");
    int input = Convert.ToInt32(Console.ReadLine());
    if ((input % 2) != 0)
    {
        if (input > max)
   {
       max = input;
   }
    }    
}
Console.WriteLine($"奇數中最大的值為：{max}");

// while
/*
Console.Write("請輸入 n 個數字：");
int max = int.MinValue;
int num = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (i < num)
{
    Console.Write($"輸入第 {i+1} 個數字：");
    int input = Convert.ToInt32(Console.ReadLine());
    if ((input % 2) != 0)
    {
        if (input > max)
        {
            max = input;
        }
    }
    i++;
    
}
Console.WriteLine($"奇數中最大的值為：{max}");
*/