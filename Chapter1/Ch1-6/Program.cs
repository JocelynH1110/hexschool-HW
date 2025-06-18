using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("請輸入任意數 : ");
var num = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("絕對值為 : " + Math.Abs(num));