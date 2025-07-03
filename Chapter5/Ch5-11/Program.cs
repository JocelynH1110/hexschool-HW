using System.Diagnostics.CodeAnalysis;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 習題：5-6.寫一程式，輸入兩組數字：a1,a2,…,a5和b1,b2,…,b5。求ai+bi，i=1到i=5。
int[] a=new int[5];
int[] b=new int[5];
int sum = 0;

for (int i = 0; i < a.Length; i++)
{
    Console.Write($"a{i+1} 為： ");
    int numA = Convert.ToInt32(Console.ReadLine());
    a[i] = numA;
    Console.Write($"b{i+1} 為： ");
    int numB = Convert.ToInt32(Console.ReadLine());
    b[i]=numB;
    sum = a[i] + b[i];
    Console.WriteLine($"a{i+1} + b{i+1} = {sum}");
}
