```powershell
$chapter = 1
$taskCount = 8

for ($i = 1; $i -le $taskCount; $i++) {
    dotnet new console -n Ch$chapter-$i -o Chapter$chapter\Ch$chapter-$i
    dotnet sln add .\Chapter$chapter\Ch$chapter-$i\Ch$chapter-$i.csproj
} 
```

```powershell
for ($i = 1; $i -le $taskCount; $i++) {
	$file = ".\Chapter$chapter\Ch$chapter-$i\Program.cs"
	$tmpl = @"
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
"@
	Set-Content -Path "$file" -Value "$tmpl" -Encoding UTF8
}
```
