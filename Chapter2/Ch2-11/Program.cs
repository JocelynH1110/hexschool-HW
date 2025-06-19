using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("請輸入當月利潤: ");
var profit = Convert.ToDouble(Console.ReadLine());
double bonus;
var bonus1 = 100000 * 0.1;
var bonus2 = bonus1 + 100000 * 0.075;
var bonus4 = bonus2 + 200000 * 0.05;
var bonus6 = bonus4 + 200000 * 0.03;
var bonus10 = bonus6 + 400000 * 0.015;
if (profit <= 100000)
{
    bonus = profit * 0.1;
}
else if (profit <= 200000)
{
    bonus = (profit - 100000) * 0.075 + 100000 * 0.1;
}
else if (profit <= 400000)
{
    bonus = (profit - 200000) * 0.05 + 100000 * 0.075 + 100000 * 0.1;
}
else if (profit <= 600000)
{
    bonus = (profit - 400000) * 0.03 + 200000 * 0.05 + 100000 * 0.075 + 100000 * 0.1;
}
else if (profit <= 1000000)
{
    bonus = (profit - 600000) * 0.015 + 200000 * 0.03 + 200000 * 0.05 + 100000 * 0.075 + 100000 * 0.1;
}
else
{
    bonus = (profit - 1000000) * 0.01 + 400000 * 0.015 + 200000 * 0.03 + 200000 * 0.05 + 100000 * 0.075 + 100000 * 0.1;
}


Console.WriteLine($"獎金總數為: {bonus}");