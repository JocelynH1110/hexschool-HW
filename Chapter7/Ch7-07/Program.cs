using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 亂數：2.請隨機由0~99產生10個數字輸出。
Random r=new Random();
//List<int> nums = new List<int>();
int[] nums= new int[10];
for (int i = 0; i < 10; i++)
{
    nums[i]=r.Next(0, 100);
    Console.WriteLine($"第 {i+1} 個數字：{nums[i]}");
}