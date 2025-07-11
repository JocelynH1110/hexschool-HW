using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 字串題目：4.輸入一個檔名輸出副檔名，如輸入apple.jpg，輸出jpg。
int index = 0;
string input;
do
{
    Console.Write("請輸入一個檔名： ");
   input=Console.ReadLine();
    index=input.IndexOf(".");

} while (index < 0);
Console.WriteLine($"{input} 的附檔名為 {input.Substring(index+1)}");