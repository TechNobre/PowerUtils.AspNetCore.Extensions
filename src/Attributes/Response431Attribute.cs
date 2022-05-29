using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Response with status code 431 (RequestHeaderFieldsTooLarge)
    /// </summary>
    public class Response431Attribute : ProducesResponseTypeAttribute
    {
        public Response431Attribute(Type type) : base(type, StatusCodes.Status431RequestHeaderFieldsTooLarge) { }
    }
}
