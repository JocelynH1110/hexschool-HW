using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 習題：5-1.寫一程式，將10個數字讀入A陣列，然後逐一檢查此陣列，如A[i]>5，則令A[i]=A[i]-5，否則A[i]=A[i]+5。

int[] a=new int[10];

Console.WriteLine("請輸入 10 個數字： ");
for (int i = 0; i < a.Length; i++)
{
    Console.Write($"A 的第 {i+1} 個值：");
    int num = Convert.ToInt32(Console.ReadLine());
    a[i] = num;
    if (a[i] > 5)
    {
        a[i] -= 5;
    }
    else
    {
        a[i] += 5;
    }
}

for (int i = 0; i < a.Length; i++)
{
    Console.Write($"A[{i}] = {a[i]}  ");
}
