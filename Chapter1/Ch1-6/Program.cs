using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 1-6請隨意輸入正負數，取絕對值輸出
Console.Write("請輸入任意數 : ");
var num = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("絕對值為 : " + Math.Abs(num));