using System.Text;

Console.OutputEncoding = Encoding.UTF8;
// 字串補充練習：
// 3.輸入時間，顯示幾時幾分，例如輸入11:30，輸出11點30分。

Console.Write("請輸入時間：");
string time=Console.ReadLine();
string[] arr = time.Split(":");
if (arr.Length ==2)
{
    Console.Write($"{arr[0]} 點 {arr[1]} 分");
}else 
{
    Console.Write($"{arr[0]} 分");
}