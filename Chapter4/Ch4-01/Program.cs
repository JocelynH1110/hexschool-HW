using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 例題4.1 讀入一連串的數字，但事先不知道數字的數目。
Console.Write("輸入一串數字：");
int num=Convert.ToInt32(Console.ReadLine());

while (num>=0)
{
    Console.WriteLine(num);
    break;
}
