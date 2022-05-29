using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Response with status code 203 (NonAuthoritative)
    /// </summary>
    public class Response203Attribute : ProducesResponseTypeAttribute
    {
        public Response203Attribute() : base(StatusCodes.Status203NonAuthoritative) { }
        public Response203Attribute(Type type) : base(type, StatusCodes.Status203NonAuthoritative) { }
    }
}
