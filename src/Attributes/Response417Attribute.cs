using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Response with status code 417 (ExpectationFailed)
    /// </summary>
    public class Response417Attribute : ProducesResponseTypeAttribute
    {
        public Response417Attribute(Type type) : base(type, StatusCodes.Status417ExpectationFailed) { }
    }
}
