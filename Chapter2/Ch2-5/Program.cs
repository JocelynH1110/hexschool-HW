using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("請輸入 x : ");
var x = Convert.ToDouble(Console.ReadLine());
Console.Write("請輸入 y : ");
var y = Convert.ToDouble(Console.ReadLine());

if (x >= y)
{
    Console.WriteLine($"x 的平方為 : {Math.Pow(x, 2)}");
}
else
{
    Console.WriteLine($"y 的平方為 : {Math.Pow(y, 2)}");
}