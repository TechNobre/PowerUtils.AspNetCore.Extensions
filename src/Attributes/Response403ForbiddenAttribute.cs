using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response403ForbiddenAttribute : ProducesResponseTypeAttribute
    {
        public Response403ForbiddenAttribute(Type type) : base(type, StatusCodes.Status403Forbidden) { }
    }
}
