using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 亂數：補充 1.請設計樂透開獎程式。
Random r = new Random();

HashSet<int> lotteryNum = new HashSet<int>();

while (lotteryNum.Count < 6)
{
    int luckyNum = r.Next(1, 53);
    lotteryNum.Add(luckyNum);
}

Console.WriteLine($"本期樂透：{string.Join(" ", lotteryNum)}");