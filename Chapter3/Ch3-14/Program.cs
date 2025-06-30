using System.Text;

Console.OutputEncoding = Encoding.UTF8;
// === 習題：3-7 寫一程式，輸入N個數字，其中有些是負數，將這些負數轉換成正數，例如-7會被轉換成7===

// for
/*
Console.Write("請輸入 n 個數字：");
int num = Convert.ToInt32(Console.ReadLine());
int a = 0;
for (int i = 0; i < num; i++)
{
    Console.Write($"輸入第 {i+1} 個數字：");
    int input = Convert.ToInt32(Console.ReadLine());
    if (input<0)
    {
        a = Math.Abs(input);
        Console.WriteLine($"負數 {input} 轉為正數為：{a}");
    }
}
*/

// while
Console.Write("輸入 n 個數字： ");
int input=Convert.ToInt32(Console.ReadLine());
int a=0;
int i=0;

while (i<input)
{
    Console.Write($"第 {i+1} 值為： ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num < 0)
    {
        a = Math.Abs(num);
        Console.WriteLine($"負數 {num} 轉為正數為：{a}");
    }
    i++;
}