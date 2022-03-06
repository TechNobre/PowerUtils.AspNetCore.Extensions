using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response429TooManyRequestsAttribute : ProducesResponseTypeAttribute
    {
        public Response429TooManyRequestsAttribute(Type type) : base(type, StatusCodes.Status429TooManyRequests) { }
    }
}
