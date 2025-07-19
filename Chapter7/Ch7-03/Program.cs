using System.ComponentModel;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
// 檔案 補充 1：寫入九九乘法表資料到一個文字檔到自己指定的文字檔。
TimesTable t = new TimesTable();
File.WriteAllText("99.txt", t.NineNine());

Console.WriteLine(File.ReadAllText("99.txt"));

public class TimesTable
{
    List<string> table = new List<string>();

    public string NineNine()
    {
        for (int i = 1; i <= 9; i += 3)
        {
            for (int j = 1; j <= 9; j++)
            {
                table.Add($"{i} * {j} = {i * j}\t");
                table.Add($"{i + 1} * {j} = {(i + 1) * j}\t");
                table.Add($"{i + 2} * {j} = {(i + 2) * j}\n");
            }

            table.Add("\n");
        }

        return string.Join("", table);
    }
}