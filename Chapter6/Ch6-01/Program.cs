using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 字串題目：1.輸入姓名，輸出 Hi~輸入的姓名，比如說輸入Justin，輸出Hi~Justin。
Console.Write("請輸入名字： ");
string name=Console.ReadLine();
Console.WriteLine($"Hi~{name}");