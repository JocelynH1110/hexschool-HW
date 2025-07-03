using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 習題 4-2.利用while寫一程式求一個等差級數數字的和，一共有N個數字，程式應該輸入最小的起始值以及數字間的差。
// (即從起始值開始，間格差，共N個 的總和)
Console.Write("輸入一個數： ");
int num=Convert.ToInt32(Console.ReadLine());
Console.Write("輸入起始值： ");
int start=Convert.ToInt32(Console.ReadLine());
Console.Write("輸入間隔： ");
int interval=Convert.ToInt32(Console.ReadLine());
int sum = 0;
int count = 0;
while (num>count)
{
    sum += start;
    start += interval;
    count++;
}
Console.WriteLine(sum);

