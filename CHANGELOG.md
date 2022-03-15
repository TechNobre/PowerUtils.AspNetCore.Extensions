# Changelog




## [1.0.0] - 2022-03-15

- Kickoff;
- Moved the attributes from [PowerUtils.AspNetCore.WebAPI](https://github.com/TechNobre/PowerUtils.AspNetCore.WebAPI) project to this one so it can be used individually;


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
