using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 檔案 1.寫一篇中文歌的歌詞到到自己指定的文字檔(使用UTF-8編碼)。
string lyric = "Baby 我們的感情 好像跳樓機\n讓我突然地升空 又急速落地\n你帶給我一場瘋狂\n劫後餘生 好難呼吸\n那天的天氣 難得放晴\n你說的話 卻把我困在雨季";
File.WriteAllText(@"/home/jocelyn/working/hexSchool/hexschool-HW/1.txt", lyric);
File.OpenText("1.txt");