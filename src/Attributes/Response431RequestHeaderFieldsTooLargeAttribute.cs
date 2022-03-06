using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response431RequestHeaderFieldsTooLargeAttribute : ProducesResponseTypeAttribute
    {
        public Response431RequestHeaderFieldsTooLargeAttribute(Type type) : base(type, StatusCodes.Status431RequestHeaderFieldsTooLarge) { }
    }
}
