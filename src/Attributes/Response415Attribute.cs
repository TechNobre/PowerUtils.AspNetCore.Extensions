using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response415Attribute : ProducesResponseTypeAttribute
    {
        public Response415Attribute(Type type) : base(type, StatusCodes.Status415UnsupportedMediaType) { }
    }
}
