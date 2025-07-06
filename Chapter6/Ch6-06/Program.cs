using System.Text;

Console.OutputEncoding = Encoding.UTF8;
// 字串題目：6.輸入一段字，輸出把輸入的一段字裡面的我，改成小明，如輸入我在唱歌，輸出小明在唱歌。Replace()
Console.Write("輸入一段字，裡面含我： ");
string s =Console.ReadLine();
Console.WriteLine(s.Replace("我","小明"));