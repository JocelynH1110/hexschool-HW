// See https://aka.ms/new-console-template for more information

using System.Text;

Console.OutputEncoding = Encoding.UTF8;
/*(1).
1.讀入兩個數x和y，選出大的那一個。
Console.Write("x: ");
int x=Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y=Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine(x);
}
else
{
    Console.WriteLine(y);
}

Console.ReadKey();
*/

/*bool haveAJob = false;
string answer;

do
{
    Console.WriteLine("你滿意這份工作嗎?");
    answer = Console.ReadLine();
}
while(answer == "滿意");

haveAJob = true;
*/

/* 2.寫一程式，輸入x和y，如果x≥y，令z=x2，否則令z=y2
Console.Write("請輸入 x： ");
double x=Convert.ToDouble(Console.ReadLine());
Console.Write("請輸入 y： ");
double y=Convert.ToDouble(Console.ReadLine());
if (x >= y)
{
    double z = Math.Pow(x, 2);
    Console.WriteLine(z);
}
else
{
    double z = Math.Pow(y, 2);
    Console.WriteLine(z);
}
*/

/*3.sagit 是一位高中電腦老師，這學期正在教學生寫C++程式。他的評分標準是依照每一位學生在 ZeroJudge 系統上解出的題數，去計算出對應的得分。規則如下：
答對題數在 0~10 者，每題給6分。
題數在 11~20 者，從第11題開始，每題給2分。(前10題還是每題給6分)
題數在 21~40 者，從第21題開始，每題給1分。
題數在 40 以上者，一律100分。
請輸入答對題數，輸出統計後分數.
Console.Write("請輸入答對題數： ");
int problems=Convert.ToInt32(Console.ReadLine());
int score = 0;
if (problems > 40)
{
    score = 100;
}
else if(problems>20)
{
    score = (problems-20) + 10 * 2 + 10 * 6;
}
else if(problems>10)
{
    score = (problems-10) * 2 + 10 * 6;
}
else
{
    score = problems * 6;
}
Console.Write(score);
*/

//4.寫一程式，輸入N個數字，求其所有奇數中的最大值。例如輸入11,12,3,24,15，答案是15。
/*
Console.Write("請輸入 n 個數字：");
int input = Convert.ToInt32(Console.ReadLine());
int max = int.MinValue;
bool max_num = false;
for (int i = 0; i < input; i++)
{
    Console.Write($"第{i+1}個數字： ");
    int num=Convert.ToInt32(Console.ReadLine());
    if (num % 2 != 0)
    {
        if (num > max)
        {
            max = num;
            max_num = true;
        }
    }
}

if (max_num)
{
    Console.Write($"最大的奇數為：{max}");
}
else
{
    Console.WriteLine("您未輸入奇數");
}
*/

/*5.寫一程式，輸入10個整數，列出其中所有大於12的數字的總和。
Console.WriteLine("輸入 10 個整數：");
int sum = 0;
for (int i = 0; i < 10; i++)
{
    Console.Write($"請輸入第 {i+1} 組數字：");
    int num=Convert.ToInt32(Console.ReadLine());
    if (num > 12)
    {
        sum += num;
    }
}
Console.WriteLine(sum);
*/

/*6.求4的階層+7的階層，使用Function 寫
Console.WriteLine($"四的階層：{factorial.number(4)}");
Console.WriteLine($"七的階層：{factorial.number(7)}");

class factorial
{
    public static int number(int n)
    {
        int sum = 1;
        for (int i = 2; i <= n; i++)
        {
            sum *= i;
        }
       return sum;
    }
}
*/

/*7.寫一程式，輸入N個數字，求其所有正數之平方的加總。例如輸入1,-2,3,-4,5五個數字，得到
// 12 + (-2)2 + 32 + (-4)2 + 52  = 1 + 9 + 25 = 35
Console.Write("請輸入 n 組數字：");
int n = Convert.ToInt32(Console.ReadLine());
double sum = 0;
for (int i = 0; i < n; i++)
{
    Console.Write($"第{i+1}個數字：");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0)
    {
        sum += Math.Pow(num, 2);
    }
}
Console.WriteLine(sum);
*/

/*8.小明貸款買房花560萬，每個月可還4萬，每還12個月，因為年終獎金可以多還一萬，請問需要幾個月還清。
int month=0;
int price = 5600000;
int paid = 0;
while (paid<price)
{
    month++;
    if (month % 12 == 0)
    {
        paid += 50000;
    }
    else
    {
        paid += 40000;
    }
}
Console.WriteLine($"還要 {month}可還清");
*/

/*9.利用一維陣列求10個數字的最大值。
int[] arr=new int[]{2,3,5,7,9,3,23,98,10,33};
int max = int.MinValue;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
}
Console.WriteLine(max);
*/

/*10.輸入一段字，輸出每個之間多一個-，如輸入apple ，輸出a-p-p-l-e。
Console.Write("請輸入一段字：");
char[] s = Console.ReadLine().ToCharArray();
Console.WriteLine(string.Join("-",s));
*/

/*11.輸入一段字，輸出把輸入的一段字裡面的我，改成小明，如輸入我在唱歌，輸出小明在唱歌。
Console.Write("輸入一段字（含有我）：");
string s=Console.ReadLine().Replace("我","小明");
Console.WriteLine(s);
*/

/*
//12.輸入的字，轉成HTML，例如輸入Justin,Amy,David
// 輸出
// <ul>
// <li>Justin<li>
// <li>Amy<li>
// <li>David<li>
// </ul>

Console.Write("輸入名字，用逗號隔開：");
string[] s=Console.ReadLine().Split(",");

Console.WriteLine("<ul>");
for (int i = 0; i < s.Length; i++)
{
    Console.WriteLine($"<li>{s[i]}</li>");
}
Console.WriteLine("</ul>");
*/

//13.下載https://data.kcg.gov.tw/dataset/9e879512-be1e-49b3-a8d6-be61100c8669/resource/4194112b-23e4-4a79-b9f2-bd0ea791d93b/download/108.csv，
//並寫程式將此資料轉成HTML TABLE 格式，並儲存到指定的HTML檔裡。
/*
string[] csv=File.ReadAllLines("fc4bb.csv");

StringBuilder html = new StringBuilder();

html.AppendLine("<!DOCTYPE html>");
html.AppendLine("<html lang=\"zh-TW\">");
html.AppendLine("<head>\n <meta charset=\"UTF-8\">\n <title>CSV 表格</title>\n </head>");
html.AppendLine("<body>");
html.AppendLine("<table border=2>");
bool isHeader = false;
foreach (var contents in csv)
{
    string[] field=contents.Split(",");
    html.AppendLine("<tr>");
    foreach (var f in field)
    {
        if (isHeader)
        {
            html.AppendLine($"<th>{System.Net.WebUtility.HtmlEncode(f)}</th>");
        }
        else
        {
            html.AppendLine($"<td>{System.Net.WebUtility.HtmlEncode(f)}</td>");
        }
    }
    html.AppendLine("</tr>");
    isHeader = false;
}
html.AppendLine("</table>");
html.AppendLine("</body> \n</html>");
File.WriteAllText("fc4bb.csv.html",html.ToString());
Console.WriteLine(File.ReadAllText("fc4bb.csv.html"));
*/


/*(2).
//1.讀入x和y，如果x>y，則回傳x-y，否則回傳y-x。
Console.Write("x:");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y:");
int y = Convert.ToInt32(Console.ReadLine());
if (x > y)
{
    Console.WriteLine(x-y);
}
else
{
    Console.WriteLine(y-x);
}
*/

//2.寫一程式，輸入x、y、u、v，如果(𝑥+𝑦)/(𝑢−𝑣)≥2，令z=x-y，否則令z=u-v。
/*
Console.Write("x:");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y:");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("u:");
int u = Convert.ToInt32(Console.ReadLine());
Console.Write("v:");
int v = Convert.ToInt32(Console.ReadLine());

if ((x + y) / (u - v) >= 2)
{
    Console.WriteLine($"z={x-y}");
}
else
{
    Console.WriteLine($"z={u-v}");
}
*/

//3.請輸入身高體重，輸出BMI並顯示這樣的BMI是正常還是過輕、過重。
/*
Console.Write("身高(cm):");
double cm = Convert.ToInt32(Console.ReadLine());
Console.Write("體重(kg):");
double kg= Convert.ToInt32(Console.ReadLine());

double bmi = kg / Math.Pow(cm / 100,2);
Console.WriteLine(bmi);

if (bmi > 24)
{
    Console.WriteLine("過重");
}
else if(bmi>18)
{
    Console.WriteLine("正常");
}
else
{
    Console.WriteLine("過輕");
}
*/

//4.求5的階層+7的階層，使用Function 寫
/*
Console.WriteLine($"5 階：{factorial.num(5)}");
Console.WriteLine($"7 階：{factorial.num(7)}");
Console.WriteLine($"5+7 階：{factorial.num(7)+factorial.num(5)}");
class factorial
{
    public static int num(int n)
    {
        int sum = 1;
        for (int i = 2; i <= n; i++)
        {
            sum *= i;
        }
        return sum;
    }
}
*/

//5.輸入一個數N，輸出 1+2+3+4+5+N的值
/*
Console.WriteLine("請輸入一個數：");
int num=Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= num; i++)
{
   sum += i;
}

Console.WriteLine(sum);
*/

//6.輸出一個九九乘法表。
/*
for (int i =1 ; i < 10; i++)
{
    for (int j = 1; j < 10; j++)
    {
        Console.Write($"{i} * {j} = {i*j}\t");
        Console.Write($"{i+1} * {j} = {(i+1)*j}\t");
        Console.Write($"{i+2} * {j} = {(i+2)*j}\n");
    }
    Console.WriteLine();
    i+=2;
}
*/

//7.寫一程式，輸入N個數字，其中有些是負數，將這些負數轉換成正數，例如-7會被轉換成7。
/*
Console.WriteLine("輸入幾組數字：");
int num=Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < num; i++)
{
    Console.Write($"第{i+1}組數字為：");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x < 0)
    {
        Console.WriteLine(Math.Abs(x));
    }
}
*/

//8.Eric覺得麥蒂勞的39元漢堡實在太便宜、太好吃了，因此他決定晚餐要把口袋裡所有錢通通拿來吃39元漢堡。
//假設他每5分鐘就能吃一個漢堡，請隨意輸入一個時間，輸出這段時間吃漢堡的紀錄。
/*
Console.WriteLine("輸入一個時間(min):");
int min=Convert.ToInt32(Console.ReadLine());
int i = 0;
int count = 0;
while (i<min)
{
    count++;
    i += 5;
}
Console.WriteLine($"{count}");
*/

//9.寫一程式，將10個數字讀入A陣列，然後逐一檢查此陣列，如A[i]>5，則令A[i]=a[i]-5，否則A[i]=A[i]+5。
/*
int[] a=new []{2,4,5,6,7,8,9,10,11,12};
for (int i = 0; i < a.Length; i++)
{
    if (a[i] > 5)
    {
        Console.WriteLine($"{a[i]} = {a[i] - 5}");
    }
    else if(a[i]<5)
    {
        Console.WriteLine($"{a[i]} = {a[i] + 5}");
    }
    else
    {
        Console.WriteLine($"{a[i]} = {a[i]}");
    }
}
*/

//10.輸入姓名，輸出 Hi~輸入的姓名，比如說輸入Justin，輸出Hi~Justin。
/*
Console.WriteLine("請輸入名字：");
Console.WriteLine(Console.ReadLine().Insert(0,"Hi~"));
*/

//11.輸入一串字，顯示輸入幾個字。
/*
Console.WriteLine("請輸入一串字：");
Console.WriteLine(Console.ReadLine().Length);
*/

//12.輸入5處數字，用空白隔開，輸出結果。例如：輸入‘11 19 12 25 1 7 12，輸出總和是87
/*
Console.WriteLine("輸入五串數字：(空白鍵隔開）");
string[] arr=Console.ReadLine().Split(" ");
int sum = 0;
for (int i = 0; i < arr.Length; i++) {
    int num = Convert.ToInt32(arr[i]);
    sum += num;
}
Console.WriteLine(sum);
*/

//13.下載https://data.kcg.gov.tw/dataset/1dae9d63-4293-4c29-8b45-e925f04b032e/resource/261f8248-6e44-4823-a233-ee596dcacb90/download/nearbypoint.csv，
//並寫程式將此資料轉成HTML TABLE 格式，並儲存到指定的HTML檔裡。
/*
string[] csv=File.ReadAllLines("fc4bb.csv");
StringBuilder html=new StringBuilder();

html.AppendLine("<!DOCTYPE html>");
html.AppendLine("<html lang=\"zh-TW\">");
html.AppendLine("<head>\n <meta charset=\"UTF-8\">\n <title>CSV 表格</title>\n </head>");
html.AppendLine("<body>");
html.AppendLine("<table border=2>");
html.AppendLine("<tr>");

bool isHeader = true;
foreach (var content in csv)
{
    string[] field = content.Split(",");
    foreach (var f in field)
    {
        if (isHeader)
        {
            html.AppendLine($"<th>{System.Net.WebUtility.HtmlEncode(f)}");
        }
        else
        {
            html.AppendLine($"<td>{System.Net.WebUtility.HtmlEncode(f)}");
        }
    }
    html.AppendLine("</tr>");
    isHeader = false;
}
html.AppendLine("</table>");
html.AppendLine("</body>");
html.AppendLine("</html>");

File.WriteAllText("new.html",html.ToString());
*/

//14.請在文字檔裡輸入所有教室裡的學員名字，讀取文字檔，隨機抽出今天的值日生，抽過不能再被抽中，直到全部學員都被抽過，才可以再被抽。
List<string> allStudents = new List<string>(){"A","B","C"};
File.WriteAllLines("all_file",allStudents);

List<string> usedStudents = new List<string>();

if (usedStudents.Count >= allStudents.Count)
{
    Console.WriteLine("全部輪過，重來！");
    usedStudents.Clear();
}

List<string> remaining = allStudents.Except(usedStudents).ToList();
Random r = new Random();
string picked=remaining[r.Next(remaining.Count)];
Console.WriteLine(picked);
usedStudents.Add(picked);

//15.輸入‘兩個日期，輸出兩個日期相差幾天。
/*
Console.Write("第一個日期：");
DateTime day1 = Convert.ToDateTime(Console.ReadLine());
Console.Write("第二個日期：");
DateTime day2 = Convert.ToDateTime(Console.ReadLine());
Console.WriteLine((day2 - day1).TotalDays);
*/