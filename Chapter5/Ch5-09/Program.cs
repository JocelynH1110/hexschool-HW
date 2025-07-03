using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 習題：5-4.寫一程式，將15個數字存入3x5的二維陣列A中，求每一行及每一列數字的和。
int[,] a=new int[2,3];

for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        Console.Write($"請輸入 A[{i},{j}] 的值：");
        int num = Convert.ToInt32(Console.ReadLine());
        a[i, j] = num;
    }
    Console.WriteLine();
}


int row = 0;
for (int m = 0; m < a.GetLength(0); m++)
{
    for (int n = 0; n < a.GetLength(1); n++)
    {
        row+= a[m, n];
    }

    Console.WriteLine($"A 的第 {m+1} 列的和：{row}");
    row = 0;
}
Console.WriteLine();

int col= 0;
for (int m = 0; m < a.GetLength(1); m++)
{
    for (int n = 0; n < a.GetLength(0); n++)
    {
        col+= a[n, m];
    }

    Console.WriteLine($"A 的第 {m+1} 行的和：{col}");
    col = 0;
}
