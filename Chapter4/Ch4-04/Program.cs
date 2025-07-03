using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 習題 4-1.利用while寫一程式求N個數字的最大值
Console.WriteLine("請輸入 n 個正整數： ");
int input=Convert.ToInt32(Console.ReadLine());
int max=int.MinValue;
int i = 0;
while (i < input)
{
    Console.Write($"第 {i+1} 個整數為：");
    int num = Convert.ToInt32(Console.ReadLine());
        if (num > max)
        {
            max = num;
        }
    i++;
}
Console.WriteLine($"最大值為 ：{max}");
