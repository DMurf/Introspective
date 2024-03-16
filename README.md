# Introspective

## Scripts for creation

```
dotnet new sln -n Introspective -o C:\Development\Introspective
dotnet new mvc --auth None --name Introspective.Web -o C:\Development\Introspective\Introspective.Web --language C# --framework net6.0
dotnet sln C:\Development\Introspective\Introspective.sln add C:\Development\Introspective\Introspective.Web/Introspective.Web.csproj
dotnet new xunit --name Introspective.Web.Tests -o C:\Development\Introspective\Tests\Introspective.Web.Tests --language C# --framework net6.0
dotnet sln C:\Development\Introspective\Introspective.sln add C:\Development\Introspective\Tests\Introspective.Web.Tests/Introspective.Web.Tests.csproj
dotnet new classlib --name Introspective.Core -o C:\Development\Introspective\Introspective.Core --language C# --framework net6.0
dotnet sln C:\Development\Introspective\Introspective.sln add C:\Development\Introspective\Introspective.Core/Introspective.Core.csproj
dotnet new xunit --name Introspective.Core.Tests -o C:\Development\Introspective\Tests\Introspective.Core.Tests --language C# --framework net6.0
dotnet sln C:\Development\Introspective\Introspective.sln add C:\Development\Introspective\Tests\Introspective.Core.Tests/Introspective.Core.Tests.csproj
dotnet new classlib --name Introspective.Infrastructure -o C:\Development\Introspective\Introspective.Infrastructure --language C# --framework net6.0
dotnet sln C:\Development\Introspective\Introspective.sln add C:\Development\Introspective\Introspective.Infrastructure/Introspective.Infrastructure.csproj
dotnet new xunit --name Introspective.Infrastructure.Tests -o C:\Development\Introspective\Tests\Introspective.Infrastructure.Tests --language C# --framework net6.0
dotnet sln C:\Development\Introspective\Introspective.sln add C:\Development\Introspective\Tests\Introspective.Infrastructure.Tests/Introspective.Infrastructure.Tests.csproj
dotnet new gitignore -o C:\Development\Introspective
dotnet format whitespace C:\Development\Introspective\Introspective.sln
dotnet add C:\Development\Introspective\Introspective.Web/Introspective.Web.csproj reference C:\Development\Introspective\Introspective.Core/Introspective.Core.csproj
dotnet add C:\Development\Introspective\Introspective.Web/Introspective.Web.csproj reference C:\Development\Introspective\Introspective.Infrastructure/Introspective.Infrastructure.csproj
dotnet add C:\Development\Introspective\Introspective.Infrastructure/Introspective.Infrastructure.csproj reference C:\Development\Introspective\Introspective.Core/Introspective.Core.csproj
```
cd /Web
npm install