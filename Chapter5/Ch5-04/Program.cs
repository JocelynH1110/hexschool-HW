using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 例題5.4求兩個2乘3的二維矩陣相加之結果，第一個及第二個矩陣分別以A及B表示，相加之結果存入C矩陣，最後將C矩陣內容顯示出來。

int[,] a=new int[2,3]
{
    { 2, 3, 2 },
    { 1, 4, 2 }
};
int[,] b=new int[2,3]
{
    { 2, 3, 2 },
    { 9, 4, 2 }
};
int[,] c = new int[2, 3];

for (int i = 0; i < c.GetLength(0) ; i++)
{
    for (int j = 0; j <c.GetLength(1) ; j++)
    {
        c[i, j] = a[i, j] + b[i, j];
        Console.Write($"{c[i,j]}\t");
    }
    Console.WriteLine();
}
