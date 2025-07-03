using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 習題：5-5.寫一程式，將15個數字存入3x5的二維陣列A中，求每一行及每一列數字的最小值。

int[,] a=new int[2,3];
int min_row = int.MaxValue;
int min_col= int.MaxValue;
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

for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        if (a[i, j] < min_row)
        {
            min_row = a[i, j];
        }
    }
    Console.WriteLine($"a 列第 {i} 列的最小值為 {min_row}");
    min_row = int.MaxValue;
}

Console.WriteLine();

for (int i = 0; i < a.GetLength(1); i++)
{
    for (int j = 0; j < a.GetLength(0); j++)
    {
        if (a[j, i] < min_col)
        {
            min_col = a[j, i];
        }
    }
    Console.WriteLine($"a 列第 {i} 行的最小值為 {min_col}");
    min_col = int.MaxValue;
}