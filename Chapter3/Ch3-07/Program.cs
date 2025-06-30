using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// === 99 乘法表 ===
// for
/*
for (int i = 1; i <= 9; i+=3)
{
    for (int j = 1; j <= 9; j++)
    {
         Console.Write($"{i} * {j} = {i*j}\t");
         Console.Write($"{i+1} * {j} = {(i+1)*j}\t");
         Console.Write($"{i+2} * {j} = {(i+2)*j}\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}
*/

// while
int i = 1;
while (i<10)
{
    int j = 1;
    while (j<10)
    {
        
        Console.Write($"{i} * {j} = {i*j}\t");
        Console.Write($"{i+1} * {j} = {(i+1)*j}\t");
        Console.Write($"{i+2} * {j} = {(i+2)*j}\t");
        Console.WriteLine();
        j++;
    }
    Console.WriteLine();

    i+=3;
}