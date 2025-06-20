using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("請輸入 x : ");
var x = Convert.ToDouble(Console.ReadLine());
Console.Write("請輸入 y : ");
var y = Convert.ToDouble(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.Write("x 與 y 皆為正數,故印出 z = 1");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("x 與 y 皆為負數,故印出 z = -1");
}
else
{
    Console.WriteLine("x 與 y 一負一正,故印出 z = 0");
}