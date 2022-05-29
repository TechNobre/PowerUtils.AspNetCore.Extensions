using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Response with status code 405 (MethodNotAllowed)
    /// </summary>
    public class Response405Attribute : ProducesResponseTypeAttribute
    {
        public Response405Attribute(Type type) : base(type, StatusCodes.Status405MethodNotAllowed) { }
    }
}
