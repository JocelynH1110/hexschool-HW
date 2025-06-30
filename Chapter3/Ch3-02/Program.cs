using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// === 讀入五個整數，求這五個整數的和 ===
// while
int i = 0;
int sum = 0;

Console.WriteLine("輸入整數： ");
while(i<5)
{
    Console.Write($"第{i+1}個值為： ");
    int input = Convert.ToInt32(Console.ReadLine());
    sum += input;
    i++;
}
Console.WriteLine($"總和為： {sum}");
