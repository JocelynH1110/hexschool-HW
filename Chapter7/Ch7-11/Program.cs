using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 亂數：補充 3.請在文字檔裡輸入所有教室裡的學員名字，讀取文字檔，隨機抽出今天的值日生，抽過不能再被抽中，直到全部學員都被抽過，才可以再被抽。
List<string> students = new List<string>() { "大花", "小美", "大牆", "阿明" };
File.WriteAllLines("studentsList.txt", students);

// 讀取已抽出名單
List<string> used = new List<string>();
string usedFile = "used.txt";
if (File.Exists(usedFile))
{
    used = new List<string>(File.ReadAllLines(usedFile));
}

List<string> remaining = new List<string>();
foreach (var s in students)
{
    if (!used.Contains(s))
    {
        remaining.Add(s);
    }
}

if (remaining.Count == 0)
{
    Console.WriteLine("全輪完，重來一次");
    File.Delete(usedFile);
    used.Clear();
}

Random r = new Random();
string picked = remaining[r.Next(remaining.Count)];
Console.Write($"今天值日生是 {picked}");