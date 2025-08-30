using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Response with status code 226 (IMUsed)
    /// </summary>
    [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
    public class Response226Attribute : ProducesResponseTypeAttribute
    {
        public Response226Attribute() : base(StatusCodes.Status226IMUsed) { }
        public Response226Attribute(Type type) : base(type, StatusCodes.Status226IMUsed) { }
    }
}
