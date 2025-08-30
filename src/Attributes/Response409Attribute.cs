using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Response with status code 409 (Conflict)
    /// </summary>
    [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
    public class Response409Attribute : ProducesResponseTypeAttribute
    {
        public Response409Attribute(Type type) : base(type, StatusCodes.Status409Conflict) { }
    }
}
