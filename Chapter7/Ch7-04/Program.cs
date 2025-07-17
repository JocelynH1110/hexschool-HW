using System.Text;

Console.OutputEncoding = Encoding.UTF8;
// 檔案 補充 2：讀取1.txt 顯示在畫面上，並將1.txt 裡的阿拉伯數字，轉換成中文數字(壹、貳、叁、肆…..)，並儲存到指定的路徑。(UTF-8)
string content = "1,2,3";
File.WriteAllText("1.txt",content);
Console.WriteLine(File.ReadAllText("1.txt"));

content = content.Replace("0", "零")
    .Replace("1", "壹")
    .Replace("2", "貳")
    .Replace("3", "參")
    .Replace("4", "肆")
    .Replace("5", "伍")
    .Replace("6", "陸")
    .Replace("7", "柒")
    .Replace("8", "捌")
    .Replace("9", "玖");

Console.WriteLine("\n轉換成中文數字：");
// 存到新的地方
File.WriteAllText("new.txt",content);
Console.WriteLine(File.ReadAllText("new.txt"));