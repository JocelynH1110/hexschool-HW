using System.Text;

Console.OutputEncoding = Encoding.UTF8;
// === 習題：3-4 寫一程式，輸入10個整數，列出其中所有大於12的數字的總和 ===
// while
Console.WriteLine("請輸入 10 個整數");
int i = 0;
int sum = 0;
while (i < 10)
{
    Console.Write($"第 {i+1} 個整數為：");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 12)
    {
        sum += num;
    }
    i++;
}
Console.WriteLine($"大於 12 的數字總和： {sum}");

// for
/*
Console.WriteLine("請輸入 10 個整數");
int sum = 0;
for (int i = 0; i < 10; i++)
{
    Console.Write($"第 {i+1} 個整數為：");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num >12)
    {
        sum += num;
    }
}
Console.WriteLine($"大於 12 的數字總和： {sum}");
*/
