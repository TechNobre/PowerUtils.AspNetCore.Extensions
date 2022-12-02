dotnet tool restore
dotnet restore
dotnet build --no-restore
dotnet stryker -tp tests/PowerUtils.AspNetCore.Extensions.Tests/PowerUtils.AspNetCore.Extensions.Tests.csproj -p PowerUtils.AspNetCore.Extensions.csproj --reporter cleartext --reporter html -o