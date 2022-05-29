using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Response with status code 205 (ResetContent)
    /// </summary>
    public class Response205Attribute : ProducesResponseTypeAttribute
    {
        public Response205Attribute() : base(StatusCodes.Status205ResetContent) { }
        public Response205Attribute(Type type) : base(type, StatusCodes.Status205ResetContent) { }
    }
}
