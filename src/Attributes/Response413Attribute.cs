using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    public class Response413Attribute : ProducesResponseTypeAttribute
    {
        public Response413Attribute(Type type) : base(type, StatusCodes.Status413RequestEntityTooLarge) { }
    }
}
