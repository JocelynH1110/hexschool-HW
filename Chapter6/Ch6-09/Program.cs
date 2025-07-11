using System.Text;

Console.OutputEncoding = Encoding.UTF8;
// 字串補充練習：
// 2.用字母大小寫來模擬波浪舞的動作後輸出，比如輸入FiFa，輸出
// Fifa
// fIfa
// fiFa
// fifA
Console.Write("請輸入一串字： ");
string input = Console.ReadLine();

for (int j = 0; j < input.Length; j++)
{
    char[] words = input.ToLower().ToCharArray(); // 字串變字元＋全小寫
    words[j] = char.ToUpper(words[j]);
    Console.WriteLine(new string(words)); // 變回字串
}