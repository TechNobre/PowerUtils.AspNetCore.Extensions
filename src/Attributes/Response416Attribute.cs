using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    public class Response416Attribute : ProducesResponseTypeAttribute
    {
        public Response416Attribute(Type type) : base(type, StatusCodes.Status416RequestedRangeNotSatisfiable) { }
    }
}
