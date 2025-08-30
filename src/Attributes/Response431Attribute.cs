using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Response with status code 431 (RequestHeaderFieldsTooLarge)
    /// </summary>
    [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
    public class Response431Attribute : ProducesResponseTypeAttribute
    {
        public Response431Attribute(Type type) : base(type, StatusCodes.Status431RequestHeaderFieldsTooLarge) { }
    }
}
