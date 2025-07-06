using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 字串補充練習：
// 1.連續輸入10組字，若沒輸入過，就顯示沒出現過，若輸入過，就顯示輸入過。
HashSet<string> w = new HashSet<string>();

Console.WriteLine("請輸入 10 組字 ");
for (int i = 0; i < 10; i++)
{
    Console.Write($"請輸入第 {i+1} 組字： ");
    string input=Console.ReadLine();
    if (w.Contains(input))
    {
        Console.WriteLine("已輸入過"); 
    }
    else
    {
        Console.WriteLine("沒出現過");
        w.Add(input);
    }
   
}