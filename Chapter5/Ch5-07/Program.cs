using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 習題：5-2.寫一程式，將10個數字讀入A陣列，對每一個數字，令A[i]=A[i]+i。
int[] a=new int[2];
for (int i = 0; i < a.Length; i++)
{
    Console.Write("輸入 10 個數：");
    int num = Convert.ToInt32(Console.ReadLine());
    a[i] = num;
    a[i] += i;
}

foreach (var item in a)
{
    Console.WriteLine(item);
}