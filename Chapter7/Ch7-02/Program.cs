using System.Text;

Console.OutputEncoding = Encoding.UTF8;
// 檔案 2. 讀取1.txt 顯示在畫面上。
string lyric = "Baby 我們的感情 好像跳樓機\n讓我突然地升空 又急速落地\n你帶給我一場瘋狂\n劫後餘生 好難呼吸\n那天的天氣 難得放晴\n你說的話 卻把我困在雨季";
File.WriteAllText("1.txt", lyric);
Console.WriteLine(File.ReadAllText("1.txt"));