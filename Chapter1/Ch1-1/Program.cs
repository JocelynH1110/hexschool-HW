using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("輸入 a : ");
var a = Convert.ToDouble(Console.ReadLine());
Console.Write("輸入 b : ");
var b = Convert.ToDouble(Console.ReadLine());
Console.Write("輸入 c : ");
var c = Convert.ToDouble(Console.ReadLine());
Console.Write("輸入 d : ");
var d = Convert.ToDouble(Console.ReadLine());

var ans = (a + b) / (c - d) * 2;
Console.WriteLine($"a = {a}, b = {b}, c = {c}, d = {d}");
Console.WriteLine("(( a + b)/( c - d )) * 2 = " + ans);