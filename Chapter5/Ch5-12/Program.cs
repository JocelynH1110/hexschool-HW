using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 習題：5-7.寫一程式，輸入兩組數字： a1,a2,…,a5和b1,b2,…,b5。令x為a中的最大值，令y為b中的最大值，求x與y中較小者。

int[] a=new int[5];
int[] b=new int[5];
int max_a = int.MinValue;
int max_b = int.MinValue;

for (int i = 0; i < a.Length; i++)
{
    Console.Write($"請輸入 a 的第 {i + 1} 個值： ");
    int numA = Convert.ToInt32(Console.ReadLine());
    a[i] = numA;

    if (a[i]> max_a)
    {
        max_a = a[i];
    }
}
Console.WriteLine();

for (int i = 0; i < b.Length; i++)
{
    Console.Write($"請輸入 b 的第 {i + 1} 個值： ");
    int numB = Convert.ToInt32(Console.ReadLine());
    b[i] = numB;
    
    if (b[i] > max_b)
    {
        max_b = b[i];
    }
}

Console.WriteLine();
for (int i = 0; i < b.Length; i++)
{
    Console.Write($"請輸入 b 的第 {i + 1} 個值： ");
    if (max_a > max_b)
    {
        Console.WriteLine($"a 與 b 組中最大的值相比，最小的是： {max_b}");
    }
    else
    {
        Console.WriteLine($"a 與 b 組中最大的值相比，最小的是： {max_a}");
    }
}

