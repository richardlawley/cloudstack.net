param(
    [String] $majorMinor = "4.8.0", # 1.4
    [String] $patch = "14",          # $env:APPVEYOR_BUILD_VERSION
    [String] $branch = "master",    # $env:APPVEYOR_REPO_BRANCH
    [String] $customLogger = "",    # C:\Program Files\AppVeyor\BuildAgent\Appveyor.MSBuildLogger.dll
    [Switch] $notouch
)

function Set-AssemblyVersions($informational, $file, $assembly)
{
    (Get-Content assets/CommonAssemblyInfo.cs) |
        ForEach-Object { $_ -replace "AssemblyVersion\(""(.*?)""\)", "AssemblyVersion(""$assembly"")" } |
        ForEach-Object { $_ -replace "AssemblyInformationalVersion\(""(.*?)""\)", "AssemblyInformationalVersion(""$informational"")" } |
        ForEach-Object { $_ -replace "AssemblyFileVersion\(""(.*?)""\)", "AssemblyFileVersion(""$file"")" } |
        Set-Content assets/CommonAssemblyInfo.cs
}

function Install-NuGetPackages()
{
    nuget restore CloudStack.Net.sln
}

function Invoke-MSBuild($solution, $customLogger)
{
    if ($customLogger)
    {
        msbuild "$solution" /verbosity:minimal /p:Configuration=Release /logger:"$customLogger"
    }
    else
    {
        msbuild "$solution" /verbosity:minimal /p:Configuration=Release
    }
}

function Invoke-NuGetPackProj($csproj)
{
    nuget pack -Prop Configuration=Release -Symbols $csproj
}

function Invoke-NuGetPackSpec($nuspec, $version)
{
    nuget pack $nuspec -Version $version -OutputDirectory ..\..\
}

function Invoke-NuGetPack($version)
{
    Invoke-NuGetPackProj src\CloudStack.Net\CloudStack.Net.csproj
    pushd .\src\CloudStack.Net
    Invoke-NuGetPackSpec "CloudStack.Net.nuspec" $version
    popd
}

function Invoke-Build($majorMinor, $patch, $branch, $customLogger, $notouch)
{
    $target = "$majorMinor"
    $file = "$target.$patch"
    $package = "$target.$patch"
    if ($branch -ne "master")
    {
        $package = "$target-pre-$patch"
    }

    Write-Output "Building CloudStack.Net $package"

    if (-not $notouch)
    {
        $assembly = "$majorMinor.$patch"

        Write-Output "Assembly version will be set to $assembly"
        Set-AssemblyVersions $package $file $assembly
    }

    Install-NuGetPackages
    
    Invoke-MSBuild "CloudStack.Net.sln" $customLogger

    Invoke-NuGetPack $package
}

$ErrorActionPreference = "Stop"
Invoke-Build $majorMinor $patch $branch $customLogger $notouch
