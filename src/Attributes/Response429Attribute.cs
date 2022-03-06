using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response429Attribute : ProducesResponseTypeAttribute
    {
        public Response429Attribute(Type type) : base(type, StatusCodes.Status429TooManyRequests) { }
    }
}
