# PowerUtils.AspNetCore.Extensions

![Logo](https://raw.githubusercontent.com/TechNobre/PowerUtils.AspNetCore.Extensions/main/assets/logo/logo_128x128.png)

***Utils, helpers and extensions to AspNetCore***

![Tests](https://github.com/TechNobre/PowerUtils.AspNetCore.Extensions/actions/workflows/tests.yml/badge.svg)
[![Mutation tests](https://img.shields.io/endpoint?style=flat&url=https%3A%2F%2Fbadge-api.stryker-mutator.io%2Fgithub.com%2FTechNobre%2FPowerUtils.AspNetCore.Extensions%2Fmain)](https://dashboard.stryker-mutator.io/reports/github.com/TechNobre/PowerUtils.AspNetCore.Extensions/main)

[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=TechNobre_PowerUtils.AspNetCore.Extensions&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=TechNobre_PowerUtils.AspNetCore.Extensions)
[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=TechNobre_PowerUtils.AspNetCore.Extensions&metric=coverage)](https://sonarcloud.io/summary/new_code?id=TechNobre_PowerUtils.AspNetCore.Extensions)
[![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=TechNobre_PowerUtils.AspNetCore.Extensions&metric=reliability_rating)](https://sonarcloud.io/summary/new_code?id=TechNobre_PowerUtils.AspNetCore.Extensions)
[![Bugs](https://sonarcloud.io/api/project_badges/measure?project=TechNobre_PowerUtils.AspNetCore.Extensions&metric=bugs)](https://sonarcloud.io/summary/new_code?id=TechNobre_PowerUtils.AspNetCore.Extensions)

[![NuGet](https://img.shields.io/nuget/v/PowerUtils.AspNetCore.Extensions.svg)](https://www.nuget.org/packages/PowerUtils.AspNetCore.Extensions)
[![Nuget](https://img.shields.io/nuget/dt/PowerUtils.AspNetCore.Extensions.svg)](https://www.nuget.org/packages/PowerUtils.AspNetCore.Extensions)
[![License: MIT](https://img.shields.io/github/license/TechNobre/PowerUtils.AspNetCore.Extensions.svg)](https://github.com/TechNobre/PowerUtils.AspNetCore.Extensions/blob/main/LICENSE)


- [Support](#support-to)
- [Dependencies](#dependencies)
- [How to use](#how-to-use)
  - [Installation](#installation)
  - [Attributes](#Attributes)
  - [Extensions](#Extensions)
    - [UseGeneralRoutePrefix](#Extensions.UseGeneralRoutePrefix)
- [Contribution](#contribution)
- [License](./LICENSE)
- [Changelog](./CHANGELOG.md)



## Support to <a name="support-to"></a>
- .NET 6.0
- .NET 5.0
- .NET 3.1



## Dependencies <a name="dependencies"></a>

- Microsoft.AspNetCore.Mvc.Core [NuGet](https://www.nuget.org/packages/Microsoft.AspNetCore.Mvc.Core/)



## How to use <a name="how-to-use"></a>

### Install NuGet package <a name="Installation"></a>
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



## Contribution <a name="contribution"></a>

If you have any questions, comments, or suggestions, please open an [issue](https://github.com/TechNobre/PowerUtils.AspNetCore.Extensions/issues/new/choose) or create a [pull request](https://github.com/TechNobre/PowerUtils.AspNetCore.Extensions/compare)