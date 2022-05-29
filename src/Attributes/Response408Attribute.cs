using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Response with status code 408 (RequestTimeout)
    /// </summary>
    public class Response408Attribute : ProducesResponseTypeAttribute
    {
        public Response408Attribute(Type type) : base(type, StatusCodes.Status408RequestTimeout) { }
    }
}
