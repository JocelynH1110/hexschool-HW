using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("請輸入 x : ");
var x = Convert.ToDouble(Console.ReadLine());
Console.Write("請輸入 y : ");
var y = Convert.ToDouble(Console.ReadLine());

if (x > 0)
{
    if (y > 0)
    {
        Console.WriteLine("1st quadrant");
    }
    else if (y == 0)
    {
        Console.WriteLine("X-axish");
    }
    else
    {
        Console.WriteLine("4th quadrant");
    }
}
else if (x == 0)
{
    if (y == 0)
    {
        Console.WriteLine("Origin");
    }
    else
    {
        Console.WriteLine("Y-axis");
    }
}
else
{
    if (y > 0)
    {
        Console.WriteLine("2nd quadrant");
    }
    else
    {
        if (y == 0)
        {
            Console.WriteLine("X-axis");
        }
        else
        {
            Console.WriteLine("3th quadrant");
        }
    }
}