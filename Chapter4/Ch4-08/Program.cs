using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 習題 4-5.利用while寫一程式，讀入a1,a2,…,a5和b1,b2,…,b5。
// 找到第一個ai>bi，即停止，並列印出ai及bi
Console.Write("共要幾組數字：");
int input = Convert.ToInt32(Console.ReadLine());
int i=0;
while (i<input)
{
    Console.Write($"第 {i+1} 組 a 值：");
    int a = Convert.ToInt32(Console.ReadLine());
    
    Console.Write($"第 {i+1} 組 b 值：");
    int b = Convert.ToInt32(Console.ReadLine());

    if (a > b)
    {
        Console.WriteLine($"a = {a},b = {b} => a > b");
        break;
    }

    i++;
}