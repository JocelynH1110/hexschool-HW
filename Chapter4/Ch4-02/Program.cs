using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 例題4.2 求最大公約數(Greatest Common Divisor，簡寫G.C.D.，或稱最大公因數)。
int a, b, c, d;
Console.Write("第一個整數：");
a=Convert.ToInt32(Console.ReadLine());
Console.Write("第二個整數：");
b=Convert.ToInt32(Console.ReadLine());

if (b > a)
{
    (a, b) = (b, a);
}

while (a%b!=0)
{
    d = a % b;
    a = b;
    b = d;
}
Console.WriteLine($"最大公因數為 {b}");
