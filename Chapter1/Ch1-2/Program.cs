using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("請輸入係數 a1 : ");
var a1 = Convert.ToDouble(Console.ReadLine());
Console.Write("請輸入係數 b1 : ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("請輸入係數 c1 : ");
var c1 = Convert.ToDouble(Console.ReadLine());

Console.Write("請輸入係數 a2 : ");
var a2 = Convert.ToDouble(Console.ReadLine());
Console.Write("請輸入係數 b2 : ");
var b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("請輸入係數 c2 : ");
var c2 = Convert.ToDouble(Console.ReadLine());

var x = (c1 * b2 - c2 * b1) / (a1 * b2 - a2 * b1);
var y = (c1 * a2 - c2 * a1) / (b1 * a2 - a1 * b2);

Console.WriteLine($"x = {x}, y = {y}");