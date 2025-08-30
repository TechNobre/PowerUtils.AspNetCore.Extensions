# PowerUtils.AspNetCore.Extensions


# :warning: DEPRECATED

This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.


![Logo](https://raw.githubusercontent.com/TechNobre/PowerUtils.AspNetCore.Extensions/main/assets/logo/logo_128x128.png)

***Utils, helpers and extensions to AspNetCore***

[![License: MIT](https://img.shields.io/github/license/TechNobre/PowerUtils.AspNetCore.Extensions.svg)](https://github.com/TechNobre/PowerUtils.AspNetCore.Extensions/blob/main/LICENSE)


- [Support to ](#support-to-)
- [Dependencies ](#dependencies-)
- [How to use ](#how-to-use-)
  - [Install NuGet package ](#install-nuget-package-)
  - [Attributes ](#attributes-)
  - [Extensions ](#extensions-)
    - [UseGeneralRoutePrefix ](#usegeneralrouteprefix-)
- [Contribution ](#contribution-)



## Support to <a name="support-to"></a>
- .NET 9.0
- .NET 8.0
- .NET 7.0
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
