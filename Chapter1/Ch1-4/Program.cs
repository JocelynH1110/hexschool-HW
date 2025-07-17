using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 1-4. 輸入a和b，求 (a^2+b^2)^0.5： (提示:使用Math)
Console.Write("請輸入 a : ");
var a = Convert.ToDouble(Console.ReadLine());
Console.Write("請輸入 b : ");
var b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Answer : " + Math.Sqrt(a * a + b * b));