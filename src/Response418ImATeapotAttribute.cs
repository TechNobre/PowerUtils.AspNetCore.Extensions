using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes.ResponseTypes
{
    public class Response418ImATeapotAttribute : ProducesResponseTypeAttribute
    {
        public Response418ImATeapotAttribute(Type type) : base(type, StatusCodes.Status418ImATeapot) { }
    }
}
