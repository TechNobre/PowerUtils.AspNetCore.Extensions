using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    public class Response208Attribute : ProducesResponseTypeAttribute
    {
        public Response208Attribute(Type type) : base(type, StatusCodes.Status208AlreadyReported) { }
    }
}
