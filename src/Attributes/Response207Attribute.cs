using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    public class Response207Attribute : ProducesResponseTypeAttribute
    {
        public Response207Attribute(Type type) : base(type, StatusCodes.Status207MultiStatus) { }
    }
}
