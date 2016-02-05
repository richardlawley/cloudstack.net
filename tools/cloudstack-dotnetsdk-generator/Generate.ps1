param (
    [string]$cloudstackbase = "C:\VMs\Cloudstackdev\cloudstack"
)

$target = "$PSScriptRoot\..\..\src\CloudStack.Net\Generated"
$builtbase = gci $cloudstackbase\client\target\cloud-client-ui-* -Directory | Select-Object -first 1
$lib = "$builtbase\WEB-INF\lib";
$classes = "$builtbase\WEB-INF\classes".Substring(2);

Set-Item -Path Env:LIB -Value $classes

$cloudjars = [string]::Join(";", (Get-ChildItem $lib -Filter cloud*.jar -File).FullName.Substring(2))
$classpath = [string]::Join(";", (Get-ChildItem $lib\* -Include *.jar).FullName.Substring(2))

$javacmd = "java -cp ""bin;$classpath"" com.cloud.api.doc.DotNetSdkGenerator -f $classes\commands.properties -d $target $cloudjars"

Cls
iex $javacmd