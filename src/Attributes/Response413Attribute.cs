using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Response with status code 413 (PayloadTooLarge)
    /// </summary>
    public class Response413Attribute : ProducesResponseTypeAttribute
    {
        public Response413Attribute(Type type) : base(type, StatusCodes.Status413PayloadTooLarge) { }
    }
}
