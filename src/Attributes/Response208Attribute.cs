using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Response with status code 208 (AlreadyReported)
    /// </summary>
    public class Response208Attribute : ProducesResponseTypeAttribute
    {
        public Response208Attribute() : base(StatusCodes.Status208AlreadyReported) { }
        public Response208Attribute(Type type) : base(type, StatusCodes.Status208AlreadyReported) { }
    }
}
