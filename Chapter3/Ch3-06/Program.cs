using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// === 求N階層，即求123…N。請求輸入N，讓for迴圈自2依序乘到N ===
// for
/*
Console.WriteLine("請輸入 n 個正整數： ");
int input=Convert.ToInt32(Console.ReadLine());
int val = 1;
for ( int i = 2; i < input+1; i++)
{
    val *= i;
}
Console.WriteLine($"{input}! = {val}");
*/

//while
Console.WriteLine("請輸入 n 個正整數： ");
int input=Convert.ToInt32(Console.ReadLine());
int val = 1;
int i= 2;
while (i<input+1)
{
    val *= i;
    i++;
}
Console.WriteLine($"{input}! = {val}");
