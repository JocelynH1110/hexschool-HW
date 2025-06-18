using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("請輸入 a : ");
var a = Convert.ToDouble(Console.ReadLine());
Console.Write("請輸入 b : ");
var b = Convert.ToDouble(Console.ReadLine());
var ans = (Math.Pow(a, 2) + Math.Pow(b, 2)) / (Math.Pow(a, 2) - Math.Pow(b, 2));
Console.WriteLine($"a = {a}, b = {b}");
Console.WriteLine("Answer : " + ans);