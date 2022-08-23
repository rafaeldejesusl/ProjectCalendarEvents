param(
  [string]$Name,
  [string]$ProjectType = "classlib"
)

function Say([string]$str) {
  Write-Host "Trybe Exercise Initializer: $str" -ForegroundColor Green
}

function Add-Dependencies() {
  dotnet add package FluentAssertions --version 6.5.1
  dotnet add package XunitXml.TestLogger --version 3.0.70
  dotnet add package Moq --version 4.17.2
}

Say "Setting up $Name exercise"

Say "Creating $Name project of type $ProjectType"
Set-Location .\src\
dotnet new $ProjectType -o $Name

Say "Creating $Name.Test project"
dotnet new xunit -o $Name`.Test

Say "Creating $Name.Test.Test project"
dotnet new xunit -o $Name`.Test.Test

Say "Setting up solution"
dotnet new sln
dotnet sln add .\$Name\$Name`.csproj
dotnet sln add .\$Name`.Test\$Name`.Test.csproj
dotnet sln add .\$Name`.Test.Test\$Name`.Test.Test.csproj

Say "Setting up references"
Set-Location .\$Name`.Test\
dotnet add reference ..\$Name\$Name`.csproj
Set-Location ..\$Name`.Test.Test\
dotnet add reference ..\$Name`.Test\$Name`.Test`.csproj

Say "Adding dependencies"
Add-Dependencies
Set-Location ..\$Name`.Test\
Add-Dependencies

Say "Adding error logging"
Set-Location ..

$csprojContent = Get-Content .\$Name\$Name`.csproj
$lineNumber = (Select-String -Path .\$Name\$Name`.csproj -Pattern "</PropertyGroup>").LineNumber
$csprojContent[$lineNumber - 2] += "`n    <ErrorLog>compiler-diagnostics.sarif</ErrorLog>"
Set-Content .\$Name\$Name`.csproj $csprojContent

Say "Restoring dependencies"
dotnet restore

Say "Initialization successful"
Set-Location ..
