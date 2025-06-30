using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 習題4-4.利用while寫一程式，讀入N個數字，找到第一個大於7而小於10的數字就停止，而且列印出這個數字。
Console.Write("共要幾組數字： ");
int input = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (i < input)
{
    Console.Write($"第 {i+1} 個數字為： ");
    int num = Convert.ToInt32(Console.ReadLine());
    if ((num >7)&&(num<10))
    {
        Console.WriteLine($"找到了是 {num}");
        break;
    }
    i++;
}
