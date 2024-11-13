# [1.5.0](https://github.com/TechNobre/PowerUtils.AspNetCore.Extensions/compare/v1.4.1...v1.5.0) (2024-11-13)


### Features

* Added support to .NET9 ([561feb0](https://github.com/TechNobre/PowerUtils.AspNetCore.Extensions/commit/561feb01ac87e56b4ecec11dc2c5a7e94f0d7422))

## [1.4.1](https://github.com/TechNobre/PowerUtils.AspNetCore.Extensions/compare/v1.4.0...v1.4.1) (2024-10-10)


### Bug Fixes

* Update System.Text.Json to fix vulnerability ([5b86218](https://github.com/TechNobre/PowerUtils.AspNetCore.Extensions/commit/5b862180411b29fcb1067db51013ffbd343728c5))

# [1.4.0](https://github.com/TechNobre/PowerUtils.AspNetCore.Extensions/compare/v1.3.0...v1.4.0) (2024-09-13)


### Features

* Added support to .NET8 ([47f26c4](https://github.com/TechNobre/PowerUtils.AspNetCore.Extensions/commit/47f26c415509ad3de0afae702ffe781e6143c302))

# [1.3.0](https://github.com/TechNobre/PowerUtils.AspNetCore.Extensions/compare/v1.2.0...v1.3.0) (2022-12-03)


### Features

* Added support to .NET 7.0 ([9e9dd5d](https://github.com/TechNobre/PowerUtils.AspNetCore.Extensions/commit/9e9dd5d94ef354a65abaeff3e42f43a4a6c86ebb))

# [1.2.0](https://github.com/TechNobre/PowerUtils.AspNetCore.Extensions/compare/v1.1.1...v1.2.0) (2022-07-19)


### Features

* Add support to debug in runtime `Microsoft.SourceLink.GitHub` ([00a85ce](https://github.com/TechNobre/PowerUtils.AspNetCore.Extensions/commit/00a85ce0292f5a47c8bde2b1b0b681bd9fc4aee4))

# [1.1.1](https://github.com/TechNobre/PowerUtils.AspNetCore.Extensions/compare/v1.1.0...v1.1.1) (2022-05-29)


### Enhancements

* Added attributes documentation;




# [1.1.0](https://github.com/TechNobre/PowerUtils.AspNetCore.Extensions/compare/v1.0.0...v1.1.0) (2022-03-16)


### New Features
- Added constructor without type parameter for `Response200Attribute`;
- Added constructor without type parameter for `Response201Attribute`;
- Added constructor without type parameter for `Response202Attribute`;
- Added constructor without type parameter for `Response203Attribute`;
- Added constructor without type parameter for `Response205Attribute`;
- Added constructor without type parameter for `Response206Attribute`;
- Added constructor without type parameter for `Response207Attribute`;
- Added constructor without type parameter for `Response208Attribute`;
- Added constructor without type parameter for `Response226Attribute`;




# 1.0.0 (2022-03-15)

- Kickoff;
- Moved the attributes from `PowerUtils.AspNetCore.WebAPI` project to this one so it can be used individually;


### Breaking Changes

- namespace `PowerUtils.AspNetCore.WebAPI.Attributes.ResponseTypes` named to `PowerUtils.AspNetCore.Attributes`;
- `Response200OK` named to `Response200Attribute`;
- `Response201Created` named to `Response201Attribute`;
- `Response204NoContent` named to `Response204Attribute`;
- Changed protected level of the `RoutePrefixConvention` to `internal`;


### New Features

- Added new Attributes:
  - Response202Attribute;
  - Response203Attribute;
  - Response205Attribute;
  - Response206Attribute;
  - Response207Attribute;
  - Response208Attribute;
  - Response226Attribute;
  - Response400Attribute with custom type;
  - Response401Attribute with custom type;
  - Response402Attribute;
  - Response403Attribute with custom type;
  - Response404Attribute with custom type;
  - Response405Attribute;
  - Response406Attribute;
  - Response407Attribute;
  - Response408Attribute;
  - Response409Attribute with custom type;
  - Response410Attribute;
  - Response411Attribute;
  - Response412Attribute;
  - Response413Attribute;
  - Response414Attribute;
  - Response415Attribute with custom type;
  - Response416Attribute;
  - Response417Attribute;
  - Response418Attribute;
  - Response422Attribute;
  - Response426Attribute;
  - Response428Attribute;
  - Response429Attribute;
  - Response431Attribute;
  - Response451Attribute;
