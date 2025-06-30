using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// === 印出 1～50 ===
int sum = 0;
for (int i= 1; i <= 50; i++)
{
    sum += i;
}
Console.WriteLine(sum);

/*
 === 印出 1～500 ===
int sum = 0;
for (int i= 1; i <= 500; i++)
{
    sum += i;
}
Console.WriteLine(sum);
*/
