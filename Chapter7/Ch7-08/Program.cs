using System.Text;

Console.OutputEncoding = Encoding.UTF8;
// 亂數：3.隨機幫每位學員產生成績，並寫入文字檔(欄位之間用，分開，換行寫入下一筆)。
List<string> students = new List<string>() { "kiki", "Lili", "Meimei", "Olu" };
Random r = new Random();

List<string> table = new List<string>();
foreach (var s in students)
{
    var score = Convert.ToString(r.Next(1, 101));
    table.Add($"{s},{score}");
}

File.WriteAllLines("list.txt", table);
Console.Write(File.ReadAllText("list.txt"));