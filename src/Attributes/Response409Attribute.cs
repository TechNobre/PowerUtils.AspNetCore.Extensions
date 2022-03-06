using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response409Attribute : ProducesResponseTypeAttribute
    {
        public Response409Attribute(Type type) : base(type, StatusCodes.Status409Conflict) { }
    }
}
