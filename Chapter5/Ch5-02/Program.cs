using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 例題5.2-利用一維陣列求10個數字的最大值。
int max = int.MinValue;
double[] arr=new double[10];
for (int i = 0; i < arr.Length; i++)
{
   Console.Write($"輸入第{i+1}個數字：");
   int num = Convert.ToInt32(Console.ReadLine());
   if (num > max)
   {
      max = num;
   }
}
Console.WriteLine($"最大值為：{max}");