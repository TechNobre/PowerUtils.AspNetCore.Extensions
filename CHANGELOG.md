# Changelog




## [1.0.0] - 2022-03-04

- Kickoff;
- Moved the attributes from [PowerUtils.AspNetCore.WebAPI](https://github.com/TechNobre/PowerUtils.AspNetCore.WebAPI) project to this one so it can be used individually;


### Breaking Changes

- namespace `PowerUtils.AspNetCore.WebAPI.Attributes.ResponseTypes` named to `PowerUtils.AspNetCore.Attributes.ResponseTypes`;


### New Features

- Added new Attributes:
  - Response202Accepted;
  - Response203NonAuthoritative;
  - Response205ResetContent;
  - Response206PartialContent;
  - Response207MultiStatus;
  - Response208AlreadyReported;
  - Response226IMUsed;
  - Response400BadRequest with custom type;
  - Response401Unauthorized with custom type;
  - Response402PaymentRequired;
  - Response403Forbidden with custom type;
  - Response404NotFound with custom type;
  - Response405MethodNotAllowed;
  - Response406NotAcceptable;
  - Response407ProxyAuthenticationRequired;
  - Response408RequestTimeout;
  - Response409Conflict with custom type;
  - Response410Gone;
  - Response411LengthRequired;
  - Response412PreconditionFailed;
  - Response413RequestEntityTooLarge;
  - Response414RequestUriTooLong;
  - Response415UnsupportedMediaType with custom type;
  - Response416RequestedRangeNotSatisfiable;
  - Response417ExpectationFailed;
  - Response418ImATeapot;
  - Response422UnprocessableEntity;
  - Response426UpgradeRequired;
  - Response428PreconditionRequired;
  - Response429TooManyRequests;
  - Response431RequestHeaderFieldsTooLarge;
  - Response451UnavailableForLegalReasons;