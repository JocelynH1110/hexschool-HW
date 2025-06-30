using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 補充：1.Eric覺得麥蒂勞的39元漢堡實在太便宜、太好吃了，因此他決定晚餐要把口袋裡所有錢通通拿來吃39元漢堡。
// 假設他每5分鐘就能吃一個漢堡，請隨意輸入一個時間，輸出這段時間吃漢堡的紀錄。
Console.WriteLine("輸入一個時間： ");
int time = Convert.ToInt32(Console.ReadLine());
int i = 0;
int count = 0;
while (i<time)
{
    count++;
    i += 5;
}

int sum = count * 39;
Console.WriteLine($"總共吃了 {count} 個漢堡,花了 {sum} 元");