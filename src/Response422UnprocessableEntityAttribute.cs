using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes.ResponseTypes
{
    public class Response422UnprocessableEntityAttribute : ProducesResponseTypeAttribute
    {
        public Response422UnprocessableEntityAttribute(Type type) : base(type, StatusCodes.Status422UnprocessableEntity) { }
    }
}
