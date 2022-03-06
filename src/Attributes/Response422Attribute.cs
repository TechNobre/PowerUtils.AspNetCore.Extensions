using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    public class Response422Attribute : ProducesResponseTypeAttribute
    {
        public Response422Attribute(Type type) : base(type, StatusCodes.Status422UnprocessableEntity) { }
    }
}
