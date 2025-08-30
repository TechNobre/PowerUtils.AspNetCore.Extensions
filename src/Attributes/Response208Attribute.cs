using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Response with status code 208 (AlreadyReported)
    /// </summary>
    [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
    public class Response208Attribute : ProducesResponseTypeAttribute
    {
        public Response208Attribute() : base(StatusCodes.Status208AlreadyReported) { }
        public Response208Attribute(Type type) : base(type, StatusCodes.Status208AlreadyReported) { }
    }
}
