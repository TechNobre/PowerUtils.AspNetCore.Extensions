using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    public class Response404Attribute : ProducesResponseTypeAttribute
    {
        public Response404Attribute(Type type) : base(type, StatusCodes.Status404NotFound) { }
    }
}
