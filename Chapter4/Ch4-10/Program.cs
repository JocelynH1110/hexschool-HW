using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 補充：2.小明貸款買房花560萬，每個月可還4萬，每還12個月，因為年終獎金可以多還一萬，請問需要幾個月還清。

int month = 0;
int price = 5600000; 
int paid = 0;

while (paid < price)
{
    month++;
    if (month % 12 == 0)
        paid += 50000;
    else
        paid += 40000;
}

Console.WriteLine($"需要還 {month} 個月才能還清");
