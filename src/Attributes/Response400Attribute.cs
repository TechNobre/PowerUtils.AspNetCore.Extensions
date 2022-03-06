using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response400Attribute : ProducesResponseTypeAttribute
    {
        public Response400Attribute(Type type) : base(type, StatusCodes.Status400BadRequest) { }
    }
}
