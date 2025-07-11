using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 字串題目：3.輸入一段字，輸出每個之間多一個-，如輸入apple ，輸出a-p-p-l-e。 

Console.Write("請輸入一段字：");
string input=Console.ReadLine();
char[] chars = input.ToCharArray();
Console.WriteLine(string.Join("-", chars));