using System.Text;

Console.OutputEncoding = Encoding.UTF8;
// 字串補充練習：
// 4.輸入的字，轉成HTML，例如輸入Justin,Amy,David 輸出
    // <ul>
    // <li>Justin<li>	
    // <li>Amy<li>
    // <li>David<li>
    // </ul>
    
    Console.Write("請輸入名字(以逗點隔開)： ");
    string names=Console.ReadLine();
    string[] name_arr = names.Split(",");
    
    Console.WriteLine("<ul>");
    for (int i = 0; i < name_arr.Length; i++)
    {
        Console.WriteLine($"    <li>{name_arr[i]}<li>");
    }
    
    Console.WriteLine("</ul>");