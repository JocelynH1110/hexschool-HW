using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 亂數：1.請隨機由0~99產生一個數字輸出。
// Random rom= new Random();//亂數種子
// int I = rom.Next(0, 100);//回傳0-99的亂數

Random r = new Random();
Console.WriteLine($"亂數為： {r.Next(0, 100)}");