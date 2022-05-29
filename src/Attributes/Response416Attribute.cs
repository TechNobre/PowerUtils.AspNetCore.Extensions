using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Response with status code 416 (RequestedRangeNotSatisfiable)
    /// </summary>
    public class Response416Attribute : ProducesResponseTypeAttribute
    {
        public Response416Attribute(Type type) : base(type, StatusCodes.Status416RequestedRangeNotSatisfiable) { }
    }
}
