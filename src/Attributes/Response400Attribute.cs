using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Response with status code 400 (BadRequest)
    /// </summary>
    public class Response400Attribute : ProducesResponseTypeAttribute
    {
        public Response400Attribute(Type type) : base(type, StatusCodes.Status400BadRequest) { }
    }
}
