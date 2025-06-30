using System.Text;

Console.OutputEncoding = Encoding.UTF8;
// === 補充：2.輸入一個數，輸出其質因數 ===

// for
/*
Console.Write("輸入一個數：");
int num = Convert.ToInt32(Console.ReadLine());
for(int i=2;i<=num;i++){
    
    while (num % i == 0)
    {
        Console.Write("他的質因數為：");
        Console.WriteLine(i);
        num = num / i;
    }
}
*/

//while
Console.Write("輸入一個數：");
int num = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i<=num)
{
    while (num % i == 0)
    {
        Console.Write("他的質因數為：");
        Console.WriteLine(i);
        num = num / i;
    }

    i++;
}
