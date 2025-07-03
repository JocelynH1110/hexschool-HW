using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 習題：5-3.寫一程式，將10個數字讀入A陣列，並建立一個B陣列，如A[i]=0，令B[i]=1，否則令B[i]=0。
int[] a=new int[10];
int[] b=new int[10];

for (int i = 0; i < a.Length; i++)
{
    Console.Write($"請輸入第 {i+1} 個數： ");
    int numA = Convert.ToInt32(Console.ReadLine());
    a[i] = numA;
    if (a[i] == 0)
    {
        b[i] = 1;
    }
    else
    {
        b[i] = 0;
    }
}

for (int i = 0; i < b.Length; i++)
{
    Console.Write($"b[{i}] = {b[i]}  ");
}