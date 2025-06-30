using System.Text;

Console.OutputEncoding = Encoding.UTF8;
// === 補充：1.判斷101-200之間有多少個質數，並輸出所有質數 ===
// for
/*
Console.WriteLine("101～200 之間有多少個質數？");
int count = 0;
for (int i = 101; i <= 200; i++)
{
    bool isPrime = true;
    int a =(int)Math.Sqrt(i);
    for (int j = 2; j <=a; j++)
    {
        if ((i % j) == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime)
    {
    Console.WriteLine($"質數有： {i}");
    count++;
    }
}
Console.WriteLine($"共有 {count} 個");
*/

//while
Console.WriteLine("101～200 之間有多少個質數？");
int count = 0;
int i = 101;
while (i<=200)
{
    bool isPrime = true;
    int a =(int)Math.Sqrt(i);
    for (int j = 2; j <=a; j++)
    {
        if ((i % j) == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime)
    {
        Console.WriteLine($"質數有： {i}");
        count++;
    }
    i++;
}
Console.WriteLine($"共有 {count} 個");
