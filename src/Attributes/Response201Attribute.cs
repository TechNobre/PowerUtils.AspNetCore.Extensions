using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response201Attribute : ProducesResponseTypeAttribute
    {
        public Response201Attribute(Type type) : base(type, StatusCodes.Status201Created) { }
    }
}
