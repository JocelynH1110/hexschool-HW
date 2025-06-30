using System.Text;

Console.OutputEncoding = Encoding.UTF8;
// === 補充：3.求100到300中可以被3與7整除的個數 ===
// for 
/*
for (int i = 100; i <= 300; i++)
{
    if ((i % 3 == 0) && (i % 7) == 0)
    {
        Console.WriteLine(i);
    }
}
*/

//while
int i=100;
while (i<=300)
{
    if ((i % 3 == 0) && (i % 7) == 0)
    {
        Console.WriteLine(i);
    }
    i++;
}