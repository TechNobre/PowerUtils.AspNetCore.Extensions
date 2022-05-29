using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Response with status code 207 (MultiStatus)
    /// </summary>
    public class Response207Attribute : ProducesResponseTypeAttribute
    {
        public Response207Attribute() : base(StatusCodes.Status207MultiStatus) { }
        public Response207Attribute(Type type) : base(type, StatusCodes.Status207MultiStatus) { }
    }
}
