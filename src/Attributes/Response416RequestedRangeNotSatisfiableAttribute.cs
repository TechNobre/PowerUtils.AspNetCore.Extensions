using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response416RequestedRangeNotSatisfiableAttribute : ProducesResponseTypeAttribute
    {
        public Response416RequestedRangeNotSatisfiableAttribute(Type type) : base(type, StatusCodes.Status416RequestedRangeNotSatisfiable) { }
    }
}
