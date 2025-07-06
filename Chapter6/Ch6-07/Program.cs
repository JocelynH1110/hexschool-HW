using System.Text;

Console.OutputEncoding = Encoding.UTF8;
// 字串題目：7.輸入一串字，顯示輸入幾個字。Length

Console.Write("輸入一串字： ");
string s=Console.ReadLine();
Console.WriteLine(s.Length);