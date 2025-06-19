using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("請輸入答對的題數: ");
var question = Convert.ToInt32(Console.ReadLine());
int score;
if (question > 40)
{
    score = 100;
}
else if (question >= 21)
{
    score = (question - 20) * 1 + 10 * 2 + 10 * 6;
}
else if (question >= 11)
{
    score = (question - 10) * 2 + 10 * 6;
}
else
{
    score = question * 6;
}

Console.WriteLine($"答對題數: {question}\n分數為: {score}");