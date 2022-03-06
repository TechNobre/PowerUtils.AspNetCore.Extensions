using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response417Attribute : ProducesResponseTypeAttribute
    {
        public Response417Attribute(Type type) : base(type, StatusCodes.Status417ExpectationFailed) { }
    }
}
