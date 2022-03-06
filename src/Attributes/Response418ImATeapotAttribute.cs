using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response418ImATeapotAttribute : ProducesResponseTypeAttribute
    {
        public Response418ImATeapotAttribute(Type type) : base(type, StatusCodes.Status418ImATeapot) { }
    }
}
