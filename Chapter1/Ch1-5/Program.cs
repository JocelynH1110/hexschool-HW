using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 1-5. 輸入a、b和c，求：
// y = a-(b+c)(3a-c)
Console.Write("請輸入 a : ");
var a = Convert.ToDouble(Console.ReadLine());
Console.Write("請輸入 b : ");
var b = Convert.ToDouble(Console.ReadLine());
Console.Write("請輸入 c : ");
var c = Convert.ToDouble(Console.ReadLine());

var y = a - (b + c) * (3 * a - c);

Console.WriteLine("Answer : " + y);