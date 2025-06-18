using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("請輸入身高 : ");
var height = Convert.ToDouble(Console.ReadLine()) / 100;
Console.Write("請輸入體重 : ");
var weight = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"身高 {height} , 體重 {weight} \nBMI = {weight / Math.Pow(height, 2):f2}");