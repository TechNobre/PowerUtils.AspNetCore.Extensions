using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response203Attribute : ProducesResponseTypeAttribute
    {
        public Response203Attribute(Type type) : base(type, StatusCodes.Status203NonAuthoritative) { }
    }
}
