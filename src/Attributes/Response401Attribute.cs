using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response401Attribute : ProducesResponseTypeAttribute
    {
        public Response401Attribute(Type type) : base(type, StatusCodes.Status401Unauthorized) { }
    }
}
