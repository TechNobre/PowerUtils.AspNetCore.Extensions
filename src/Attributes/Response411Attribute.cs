using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Response with status code 411 (LengthRequired)
    /// </summary>
    public class Response411Attribute : ProducesResponseTypeAttribute
    {
        public Response411Attribute(Type type) : base(type, StatusCodes.Status411LengthRequired) { }
    }
}
