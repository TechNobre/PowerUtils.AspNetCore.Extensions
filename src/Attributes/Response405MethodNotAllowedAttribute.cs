using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response405MethodNotAllowedAttribute : ProducesResponseTypeAttribute
    {
        public Response405MethodNotAllowedAttribute(Type type) : base(type, StatusCodes.Status405MethodNotAllowed) { }
    }
}
