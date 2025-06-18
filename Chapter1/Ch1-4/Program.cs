using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("請輸入 a : ");
var a = Convert.ToDouble(Console.ReadLine());
Console.Write("請輸入 b : ");
var b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Answer : " + Math.Sqrt(a * a + b * b));