using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Response with status code 429 (TooManyRequests)
    /// </summary>
    public class Response429Attribute : ProducesResponseTypeAttribute
    {
        public Response429Attribute(Type type) : base(type, StatusCodes.Status429TooManyRequests) { }
    }
}
