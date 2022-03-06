using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response422UnprocessableEntityAttribute : ProducesResponseTypeAttribute
    {
        public Response422UnprocessableEntityAttribute(Type type) : base(type, StatusCodes.Status422UnprocessableEntity) { }
    }
}
