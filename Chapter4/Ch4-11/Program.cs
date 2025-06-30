using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 補充：3.系統隨機產生一個數字，讓使用者數入數字，直到猜中才離開程式！
// 猜錯時，要提示是比較大還是比較小。
Console.WriteLine("猜一個1-10的數：");
Random r=new Random();
int num =r.Next(1,11);
while (true)
{
    int guess = Convert.ToInt32(Console.ReadLine());
    
    if (guess > num)
    {
        Console.WriteLine("猜太大了");
    }else if (num > guess)
    {
        Console.WriteLine("猜太小了");
    }
    else
    {
        Console.WriteLine($"猜對了是 {num}");
        break;
    }
}
