using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 字串題目：5.輸入一個大於五個字的單字，若小於五個字輸出長度不夠，若大於五個字，則輸出前三個字。Length  Substring()
Console.Write("請輸入一個大五個字母的單字： ");
string word=Console.ReadLine();
if (word.Length < 5)
{
    Console.WriteLine("字長度不夠～");
}
else
{
    Console.WriteLine(word.Substring(0,3));
}