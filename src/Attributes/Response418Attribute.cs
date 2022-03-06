using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response418Attribute : ProducesResponseTypeAttribute
    {
        public Response418Attribute(Type type) : base(type, StatusCodes.Status418ImATeapot) { }
    }
}
