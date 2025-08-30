using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Response with status code 408 (RequestTimeout)
    /// </summary>
    [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
    public class Response408Attribute : ProducesResponseTypeAttribute
    {
        public Response408Attribute(Type type) : base(type, StatusCodes.Status408RequestTimeout) { }
    }
}
