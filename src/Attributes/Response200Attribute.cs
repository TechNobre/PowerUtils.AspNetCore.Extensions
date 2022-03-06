using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response200Attribute : ProducesResponseTypeAttribute
    {
        public Response200Attribute(Type type) : base(type, StatusCodes.Status200OK) { }
    }
}
