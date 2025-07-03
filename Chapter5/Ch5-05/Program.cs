using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 例題5.5-求2乘3的A矩陣乘以3乘1的B矩陣，結果存入2乘1的C矩陣，最後將C矩陣的內容顯示出來。
int[,] a=new int[2,3]
{
    { 2, 3, 2 },
    { 1, 4, 2 }
};
int[,] b=new int[3,1]
{
    { 2},
    { 1},
    {2 }
};
int[,] c = new int[a.GetLength(0), b.GetLength(1)];

for (int i = 0; i < a.GetLength(0) ; i++)
{
    for (int j = 0; j <b.GetLength(1) ; j++)
    {
        for (int k = 0; k < a.GetLength(1); k++)
        {
            c[i,j]+= a[i,k]*b[k,j];
        }
        Console.Write($"{c[i,j]}\t");
    }
}
