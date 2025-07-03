using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 例題5.3-搜尋問題：輸入10個數字至A[ ]，再輸入x，判斷x是否存在於A陣列中，
// 如果存在，輸出所在的註標(索引)值，若不存在，則告知不存在。

int[] arr=new int[10]{1, 2, 3, 4, 5, 6, 5, 8, 9,10};
Console.Write("請輸入要找尋的數字：");
int num=Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < arr.Length; i++)
{
    if (num==arr[i])
    {
        Console.WriteLine($"您輸入的值存在於 array[{num}]的值");

    }
    else
    {
        Console.WriteLine($"您的值不存在於 array[{i}]！");
    }
} 
