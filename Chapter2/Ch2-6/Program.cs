using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("請輸入收入 : ");
var income = Convert.ToDouble(Console.ReadLine());
double rate, difference;
if (income > 4090000)
{
    rate = 0.4;
    difference = 721100;
}
else if (income > 2180000)
{
    rate = 0.3;
    difference = 312100;
}
else if (income > 1090000)
{
    rate = 0.21;
    difference = 115900;
}
else if (income > 410000)
{
    rate = 0.13;
    difference = 28700;
}
else
{
    rate = 0.06;
    difference = 0;
}

var tax = income * rate - difference;

Console.WriteLine($"income: {income}\nrate: {rate}\ndifference: {difference}\ntax: {tax}");