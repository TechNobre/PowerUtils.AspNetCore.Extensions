using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response400BadRequestAttribute : ProducesResponseTypeAttribute
    {
        public Response400BadRequestAttribute(Type type) : base(type, StatusCodes.Status400BadRequest) { }
    }
}
