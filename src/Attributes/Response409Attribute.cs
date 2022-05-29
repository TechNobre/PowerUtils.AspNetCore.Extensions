using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Response with status code 409 (Conflict)
    /// </summary>
    public class Response409Attribute : ProducesResponseTypeAttribute
    {
        public Response409Attribute(Type type) : base(type, StatusCodes.Status409Conflict) { }
    }
}
