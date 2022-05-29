using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Response with status code 428 (PreconditionRequired)
    /// </summary>
    public class Response428Attribute : ProducesResponseTypeAttribute
    {
        public Response428Attribute(Type type) : base(type, StatusCodes.Status428PreconditionRequired) { }
    }
}
