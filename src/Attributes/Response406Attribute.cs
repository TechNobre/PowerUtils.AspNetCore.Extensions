using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Response with status code 406 (NotAcceptable)
    /// </summary>
    public class Response406Attribute : ProducesResponseTypeAttribute
    {
        public Response406Attribute(Type type) : base(type, StatusCodes.Status406NotAcceptable) { }
    }
}
