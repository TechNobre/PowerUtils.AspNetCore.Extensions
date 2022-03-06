using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response428Attribute : ProducesResponseTypeAttribute
    {
        public Response428Attribute(Type type) : base(type, StatusCodes.Status428PreconditionRequired) { }
    }
}
