# PowerUtils.AspNetCore.Extensions
Utils, helpers and extensions to AspNetCore

![Tests](https://github.com/TechNobre/PowerUtils.AspNetCore.Extensions/actions/workflows/test-project.yml/badge.svg)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=TechNobre_PowerUtils.AspNetCore.Extensions&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=TechNobre_PowerUtils.AspNetCore.Extensions)
[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=TechNobre_PowerUtils.AspNetCore.Extensions&metric=coverage)](https://sonarcloud.io/summary/new_code?id=TechNobre_PowerUtils.AspNetCore.Extensions)

[![NuGet](https://img.shields.io/nuget/v/PowerUtils.AspNetCore.Extensions.svg)](https://www.nuget.org/packages/PowerUtils.AspNetCore.Extensions)
[![Nuget](https://img.shields.io/nuget/dt/PowerUtils.AspNetCore.Extensions.svg)](https://www.nuget.org/packages/PowerUtils.AspNetCore.Extensions)
[![License: MIT](https://img.shields.io/github/license/TechNobre/PowerUtils.AspNetCore.Extensions.svg)](https://github.com/TechNobre/PowerUtils.AspNetCore.Extensions/blob/main/LICENSE)



## Support to
- .NET 3.1, .NET 5.0 and .NET 6.0



## Features

- [Installation](#Installation)
- [Attributes](#Attributes)
- [Extensions](#Extensions)
  - [UseGeneralRoutePrefix](#Extensions.UseGeneralRoutePrefix)


## Documentation

### How to use

#### Install NuGet package <a name="Installation"></a>
This package is available through Nuget Packages: https://www.nuget.org/packages/PowerUtils.AspNetCore.Extensions

**Nuget**
```bash
Install-Package PowerUtils.AspNetCore.Extensions
```

**.NET CLI**
```
dotnet add package PowerUtils.AspNetCore.Extensions
```



### Attributes <a name="Attributes"></a>
- `Response2XX`;
  - `Response200Attribute`;
  - `Response201Attribute`;
  - `Response202Attribute`;
  - `Response203Attribute`;
  - `Response204Attribute`;
  - `Response205Attribute`;
  - `Response206Attribute`;
  - `Response207Attribute`;
  - `Response208Attribute`;
  - `Response226Attribute`;
- `Response4XX`;
  - `Response400Attribute`;
  - `Response401Attribute`;
  - `Response402Attribute`;
  - `Response403Attribute`;
  - `Response404Attribute`;
  - `Response405Attribute`;
  - `Response406Attribute`;
  - `Response407Attribute`;
  - `Response408Attribute`;
  - `Response409Attribute`;
  - `Response410Attribute`;
  - `Response411Attribute`;
  - `Response412Attribute`;
  - `Response413Attribute`;
  - `Response414Attribute`;
  - `Response415Attribute`;
  - `Response416Attribute`;
  - `Response417Attribute`;
  - `Response418Attribute`;
  - `Response422Attribute`;
  - `Response426Attribute`;
  - `Response428Attribute`;
  - `Response429Attribute`;
  - `Response431Attribute`;
  - `Response451Attribute`;



### Extensions <a name="Extensions"></a>


#### UseGeneralRoutePrefix <a name="Extensions.UseGeneralRoutePrefix"></a>

```csharp
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers(configure =>
            configure.UseGeneralRoutePrefix("/samples")
        );
    }
}
```



## Contribution

*Help me to help others*




## LICENSE

[MIT](https://github.com/TechNobre/PowerUtils.AspNetCore.Extensions/blob/main/LICENSE)




## Changelog

[Here](./CHANGELOG.md)