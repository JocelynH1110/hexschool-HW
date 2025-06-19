using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("請輸入 x : ");
var x = Convert.ToDouble(Console.ReadLine());
Console.Write("請輸入 y : ");
var y = Convert.ToDouble(Console.ReadLine());
Console.Write("請輸入 u : ");
var u = Convert.ToDouble(Console.ReadLine());
Console.Write("請輸入 v : ");
var v = Convert.ToDouble(Console.ReadLine());

if (x + y > u + v)
{
    var z = x + y;
    Console.WriteLine(z);
}
else
{
    var z = u + v;
    Console.WriteLine(z);
}