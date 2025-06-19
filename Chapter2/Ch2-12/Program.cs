using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("請輸入學生分數: ");
var score = Convert.ToInt32(Console.ReadLine());

switch (score / 10)
{
    case 10:
    case 9:
        Console.Write("grade = \"A\"");
        break;
    case 8:
        Console.Write("grade = \"B\"");
        break;
    case 7:
        Console.Write("grade = \"C\"");
        break;
    case 6:
        Console.Write("grade = \"D\"");
        break;
    default:
        Console.Write("grade = \"F\"");
        break;
}