using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("請輸入第一個數字: ");
var a = Convert.ToDouble(Console.ReadLine());
Console.Write("請輸入第二個數字: ");
var b = Convert.ToDouble(Console.ReadLine());
Console.Write("請輸入第三個數字: ");
var c = Convert.ToDouble(Console.ReadLine());

double one, two, three;

if (a >= b && a >= c)
{
    one = a;
    if (b >= c)
    {
        two = b;
        three = c;
    }
    else
    {
        two = c;
        three = b;
    }
}
else if (b >= a && b >= c)
{
    one = b;
    if (a >= c)
    {
        two = a;
        three = c;
    }
    else
    {
        two = c;
        three = a;
    }
}
else
{
    one = c;
    if (a >= b)
    {
        two = a;
        three = b;
    }
    else
    {
        two = b;
        three = a;
    }
}

Console.WriteLine($"由大排到小: {one},{two},{three}");