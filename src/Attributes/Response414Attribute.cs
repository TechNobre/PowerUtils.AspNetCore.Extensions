using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Response with status code 414 (RequestUriTooLong)
    /// </summary>
    public class Response414Attribute : ProducesResponseTypeAttribute
    {
        public Response414Attribute(Type type) : base(type, StatusCodes.Status414RequestUriTooLong) { }
    }
}
