using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Response with status code 401 (Unauthorized)
    /// </summary>
    public class Response401Attribute : ProducesResponseTypeAttribute
    {
        public Response401Attribute(Type type) : base(type, StatusCodes.Status401Unauthorized) { }
    }
}
