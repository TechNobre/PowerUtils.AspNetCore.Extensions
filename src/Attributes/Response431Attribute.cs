using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    public class Response431Attribute : ProducesResponseTypeAttribute
    {
        public Response431Attribute(Type type) : base(type, StatusCodes.Status431RequestHeaderFieldsTooLarge) { }
    }
}
