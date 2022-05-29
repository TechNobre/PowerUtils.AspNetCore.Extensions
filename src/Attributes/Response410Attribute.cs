using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Response with status code 410 (Gone)
    /// </summary>
    public class Response410Attribute : ProducesResponseTypeAttribute
    {
        public Response410Attribute(Type type) : base(type, StatusCodes.Status410Gone) { }
    }
}
