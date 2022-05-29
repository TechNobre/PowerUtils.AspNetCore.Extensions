using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Response with status code 200 (OK)
    /// </summary>
    public class Response200Attribute : ProducesResponseTypeAttribute
    {
        public Response200Attribute() : base(StatusCodes.Status200OK) { }
        public Response200Attribute(Type type) : base(type, StatusCodes.Status200OK) { }
    }
}
