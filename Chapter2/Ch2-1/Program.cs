using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("請輸入 x : ");
var x = Convert.ToDouble(Console.ReadLine());
Console.Write("請輸入 y : ");
var y = Convert.ToDouble(Console.ReadLine());

if (x >= y)
{
    Console.WriteLine(" x >= y , 故印出 x 值 " + x);
}
else
{
    Console.WriteLine(" x < y , 故印出 y 值 " + y);
}