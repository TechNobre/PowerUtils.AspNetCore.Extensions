using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    public class Response451Attribute : ProducesResponseTypeAttribute
    {
        public Response451Attribute(Type type) : base(type, StatusCodes.Status451UnavailableForLegalReasons) { }
    }
}
