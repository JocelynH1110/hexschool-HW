using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.Write("請輸入身高 : ");
var height = Convert.ToDouble(Console.ReadLine()) / 100;
Console.Write("請輸入體重 : ");
var weight = Convert.ToDouble(Console.ReadLine());
var bmi = weight / Math.Pow(height, 2);

if (bmi >= 24)
{
    Console.WriteLine("體重過重");
}
else if (bmi < 18.5)
{
    Console.WriteLine("體重過輕");
}
else
{
    Console.WriteLine("標準體重");
}