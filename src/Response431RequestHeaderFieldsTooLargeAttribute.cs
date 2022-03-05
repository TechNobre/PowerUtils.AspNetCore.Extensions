using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes.ResponseTypes
{
    public class Response431RequestHeaderFieldsTooLargeAttribute : ProducesResponseTypeAttribute
    {
        public Response431RequestHeaderFieldsTooLargeAttribute(Type type) : base(type, StatusCodes.Status431RequestHeaderFieldsTooLarge) { }
    }
}
