using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Response with status code 415 (UnsupportedMediaType)
    /// </summary>
    public class Response415Attribute : ProducesResponseTypeAttribute
    {
        public Response415Attribute(Type type) : base(type, StatusCodes.Status415UnsupportedMediaType) { }
    }
}
