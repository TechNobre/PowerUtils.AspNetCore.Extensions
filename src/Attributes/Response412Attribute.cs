using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response412Attribute : ProducesResponseTypeAttribute
    {
        public Response412Attribute(Type type) : base(type, StatusCodes.Status412PreconditionFailed) { }
    }
}
