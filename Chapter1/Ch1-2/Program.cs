using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 1-2.假設有一組二元一次方程式如下：
// 	a1x+b1y=c1  ，  a1x+b2y=c2
// 	此組方程式的解如下：
// 	x  ，  
// 寫一程式，輸入此方程式變數之係數，輸出方程式的解。
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