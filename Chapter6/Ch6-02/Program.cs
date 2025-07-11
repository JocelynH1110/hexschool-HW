using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 字串題目：2. 請輸入任何一個字，是否出現在”人人為我，我為人人、饒人不癡漢，癡漢不饒人”這個字串裡

string input="人人為我，我為人人、饒人不癡漢，癡漢不饒人";
Console.Write("請輸入一個字：");
string s=Console.ReadLine();
Console.WriteLine(input.Contains(s));