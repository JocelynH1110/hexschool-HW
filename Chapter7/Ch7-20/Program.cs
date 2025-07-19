using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 日期：補充 3.
// 兩光法師時常替人占卜，由於他算得又快有便宜，因此生意源源不絕，時常大排長龍，他想算 得更快一點，因此找了你這位電腦高手幫他用電腦來加快算命的速度。
// 他的占卜規則很簡單，規則是這樣的，隨機產生一個今年日期，然後依照下面的公式：
// M=月
// D=日
// S=(M*2+D)%3
// 得到 S 的值，再依照 S 的值從 0 到 2 分別給與 普通、吉、大吉 等三種不同的運勢，輸出運勢。

Random rnd = new Random();
int month = rnd.Next(1, 13);
int day = rnd.Next(1, DateTime.DaysInMonth(DateTime.Now.Year, month) + 1);
int S = ((int)(month * 2 + day)) % 3;

var result = S switch
{
    0 => "普通",
    1 => "吉",
    2 => "大吉"
};

Console.WriteLine($"您今日的運勢是: {result}");