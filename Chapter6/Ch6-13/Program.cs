using System.Text;
using System.Linq;
Console.OutputEncoding = Encoding.UTF8;
// 字串補充練習：
// 6.輸入一串文字，倒著輸出，例如輸入：Justin，輸出nitsuJ
Console.Write("輸入一串字串： ");
string input=Console.ReadLine();
string r =new string(input.Reverse().ToArray());

Console.WriteLine(r);
