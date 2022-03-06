using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response415UnsupportedMediaTypeAttribute : ProducesResponseTypeAttribute
    {
        public Response415UnsupportedMediaTypeAttribute(Type type) : base(type, StatusCodes.Status415UnsupportedMediaType) { }
    }
}
