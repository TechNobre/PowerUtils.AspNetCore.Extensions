using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Response with status code 403 (Forbidden)
    /// </summary>
    public class Response403Attribute : ProducesResponseTypeAttribute
    {
        public Response403Attribute(Type type) : base(type, StatusCodes.Status403Forbidden) { }
    }
}
