using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 亂數：補充 3.請在文字檔裡輸入所有教室裡的學員名字，讀取文字檔，隨機抽出今天的值日生，抽過不能再被抽中，直到全部學員都被抽過，才可以再被抽。
// 所有學生名單
string allstudentsfile= @"/home/jocelyn/Desktop/allStudentsFile";
HashSet<string> allStudents = new HashSet<string>() { "大花", "小美", "大牆", "阿明" };
File.WriteAllLines(allstudentsfile, allStudents);

// 讀取已抽出名單
HashSet<string> usedStudents = new HashSet<string>();
string usedFile = @"/home/jocelyn/Desktop/used.txt";
if (File.Exists(usedFile))
{
    usedStudents = File.ReadAllLines(usedFile).ToHashSet();
}

if (usedStudents.Count >= allStudents.Count)
{
    Console.WriteLine("所有人都輪過，重新開始");
    usedStudents.Clear();
}

List<string> remaining = allStudents.Except(usedStudents).ToList();
// 隨機抽一個
Random r = new Random();
    string picked = remaining[r.Next(remaining.Count)];
    Console.WriteLine($"今天值日生是 {picked}");

    usedStudents.Add(picked);
    File.WriteAllLines(usedFile,usedStudents);