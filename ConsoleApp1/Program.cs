// See https://aka.ms/new-console-template for more information

using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 計算平方根
// Console.WriteLine("輸入 x :");
// var x = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("x 的平方根為:" + Math.Pow(x, 0.5));

// 計算二次方 a2 + b2：
// var a = Convert.ToDouble(Console.ReadLine());
// var b = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine(Math.Pow(a, 2) + Math.Pow(b, 2));

// ====習題====
// 1-1
/*
Console.Write("輸入 a : ");
var a = Convert.ToDouble(Console.ReadLine());
Console.Write("輸入 b : ");
var b = Convert.ToDouble(Console.ReadLine());
Console.Write("輸入 c : ");
var c = Convert.ToDouble(Console.ReadLine());
Console.Write("輸入 d : ");
var d = Convert.ToDouble(Console.ReadLine());

var ans = (a + b) / (c - d) * 2;
Console.WriteLine($"a = {a}, b = {b}, c = {c}, d = {d}");
Console.WriteLine("(( a + b)/( c - d )) * 2 = " + ans);
*/

// 1-3
/*
Console.Write("請輸入 a : ");
var a = Convert.ToDouble(Console.ReadLine());
Console.Write("請輸入 b : ");
var b = Convert.ToDouble(Console.ReadLine());
var ans = (Math.Pow(a, 2) + Math.Pow(b, 2))/(Math.Pow(a, 2)-Math.Pow(b, 2));
Console.WriteLine($"a = {a}, b = {b}");
Console.WriteLine("Answer : " + ans);
*/
// 1-4
/*
Console.Write("請輸入 a : ");
var a = Convert.ToDouble(Console.ReadLine());
Console.Write("請輸入 b : ");
var b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Answer : "+ Math.Sqrt( a * a + b * b ));
*/

// 1-5
/*
Console.Write("請輸入 a : ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("請輸入 b : ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("請輸入 c : ");
double c = Convert.ToDouble(Console.ReadLine());

double y = a - (b + c) * (3 * a - c);

Console.WriteLine("Answer : " + y);
*/
// Console.WriteLine("x");
// int x =Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("y");
// int y =Convert.ToInt32(Console.ReadLine());
// if (x > y)
// {
// Console.WriteLine("x-y");
// }
// else
// {
// Console.WriteLine("y-x");
// }

// 1-6 
/*
Console.Write("請輸入任意數 : ");
var num = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("絕對值為 : " + Math.Abs(num));
*/

// 1-7
/*
Console.Write("請輸入西元年 : ");
var year = Convert.ToInt32(Console.ReadLine());
var mingGo = year - 1911;

Console.WriteLine($"西元 {year} 為 民國 {mingGo} 年");
*/

// 1-8
/*
Console.Write("請輸入身高 : ");
var height = Convert.ToDouble(Console.ReadLine()) / 100;
Console.Write("請輸入體重 : ");
var weight = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"身高 {height} , 體重 {weight} \nBMI = {weight / Math.Pow(height, 2):f2}");
*/

// Console.WriteLine("分數:");
// int score=Convert.ToInt32(Console.ReadLine());
// if (score >= 90)
// {
// Console.WriteLine("A");
// }else if (score >= 80 && score <= 89)
// {
// Console.WriteLine("B");
// }else if (score >= 70 && score <= 79)
// {
// Console.WriteLine("C");
// }else if (score>= 60 && score<= 69)
// {
// Console.WriteLine("D");
// }
// else if(sorce<60 && sorce>0)
// {
// Console.WriteLine("F");
// }else 
// {
// Console.WriteLine("輸入不得為負數");
// }

// ====習題====
// 2-1
/*
Console.Write("請輸入 x : ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("請輸入 y : ");
double y = Convert.ToDouble(Console.ReadLine());

if (x >= y)
{
    Console.WriteLine(" x >= y , 故印出 x 值 "+ x);
}
else
{
    Console.WriteLine(" x < y , 故印出 y 值 "+y);
}
*/

// 2-2 
/*
Console.Write("請輸入 x : ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("請輸入 y : ");
double y = Convert.ToDouble(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.Write("z = 1");
}else if (x < 0 && y < 0)
{
    Console.WriteLine("z = -1");
}
else
{
    Console.WriteLine("z = 0");
}
*/

// 2-3
/*
Console.Write("請輸入 x : ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("請輸入 y : ");
double y = Convert.ToDouble(Console.ReadLine());
Console.Write("請輸入 u : ");
double u = Convert.ToDouble(Console.ReadLine());
Console.Write("請輸入 v : ");
double v = Convert.ToDouble(Console.ReadLine());

if ((x + y) > (u + v))
{
    double z = x + y;
    Console.WriteLine(z);
}
else
{
    double z = u + v;
    Console.WriteLine(z);
}
*/

// 2-4
Console.Write("請輸入 x : ");
var x = Convert.ToDouble(Console.ReadLine());
Console.Write("請輸入 y : ");
var y = Convert.ToDouble(Console.ReadLine());
Console.Write("請輸入 u : ");
var u = Convert.ToDouble(Console.ReadLine());
Console.Write("請輸入 v : ");
var v = Convert.ToDouble(Console.ReadLine());

if ((x + y) / (u + v) >= 2)
{
    var z = x + y;
    Console.Write($"{z:F2}");
}
else
{
    var z = u + v;
    Console.Write($"{z:F2}");
}