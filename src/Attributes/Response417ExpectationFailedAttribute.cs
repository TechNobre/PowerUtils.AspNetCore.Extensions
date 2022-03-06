using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response417ExpectationFailedAttribute : ProducesResponseTypeAttribute
    {
        public Response417ExpectationFailedAttribute(Type type) : base(type, StatusCodes.Status417ExpectationFailed) { }
    }
}
