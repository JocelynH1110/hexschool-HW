using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 習題 4-3.利用while寫一程式，讀入N個數字，然後找出所有小於13的數，再求這些數字的和
Console.Write("請輸入數字： ");
int input = Convert.ToInt32(Console.ReadLine());
int i = 0;
int sum = 0;
while (i < input)
{
    Console.Write($"第 {i+1} 個數字為： ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num < 13)
    {
        sum+=num;
    }

    i++;
}
Console.WriteLine(sum);