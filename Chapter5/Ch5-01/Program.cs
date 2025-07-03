using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 例題5.1-利用一維陣列求10個數字的計算平均值。
int[] arr=new int[10];
Console.WriteLine("請輸入10個數字： ");
double sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"第 {i+1} 個值為： ");
    double input = Convert.ToInt32(Console.ReadLine());
    arr[i]=(int)input;
    sum += arr[i];
}
Console.WriteLine($"平均值為 {sum/arr.Length}");