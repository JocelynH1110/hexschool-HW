using System.Text;

Console.OutputEncoding = Encoding.UTF8;
// 檔案 補充 3：讀取fc4bb.csv，並將此資料轉成HTML TABLE 格式，並儲存到指定的HTML檔裡。
string[] csv=(File.ReadAllLines("fc4bb.csv"));

StringBuilder html=new StringBuilder();

html.AppendLine("<!DOCTYPE html>");
html.AppendLine("<html lang=\"zh-TW\">");
html.AppendLine("<head>\n <meta charset=\"UTF-8\">\n <title>CSV 表格</title>\n </head>");
html.AppendLine("<body>");
html.AppendLine("<table>");

bool isHeader = true;
foreach (var content in csv)
{
   var fields = content.Split(',');
   html.AppendLine("<tr>");

   foreach (var field in fields)
   {
       if (isHeader)
       {
           html.AppendLine($"<th>{System.Net.WebUtility.HtmlEncode(field)}</th>");
       }
       else
       {
           html.AppendLine($"<td>{System.Net.WebUtility.HtmlEncode(field)}</td>");
       } 
   }
   html.AppendLine("</tr>");
   isHeader = false;
}
html.AppendLine("</table>");
html.AppendLine("</body>\n </html>");

File.WriteAllText("fc4bb.csv.html",html.ToString());
Console.Write(File.ReadAllText("fc4bb.csv"));