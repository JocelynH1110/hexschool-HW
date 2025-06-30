using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// === 求N個整數的和，N由使用者輸入 ===
// for
/*
int sum = 0;
int intput = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <=intput; i++)
{
   sum += i;
}
Console.WriteLine(sum);
*/

// while
int sum = 0;
int input = Convert.ToInt32(Console.ReadLine());
int i = 0;
while(i<=input)
{
   sum += i;
   i++;
}
Console.WriteLine(sum);
