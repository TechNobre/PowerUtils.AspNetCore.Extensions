using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes.ResponseTypes
{
    public class Response415UnsupportedMediaTypeAttribute : ProducesResponseTypeAttribute
    {
        public Response415UnsupportedMediaTypeAttribute(Type type) : base(type, StatusCodes.Status415UnsupportedMediaType) { }
    }
}
