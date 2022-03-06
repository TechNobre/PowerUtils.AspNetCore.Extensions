using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response404NotFoundAttribute : ProducesResponseTypeAttribute
    {
        public Response404NotFoundAttribute(Type type) : base(type, StatusCodes.Status404NotFound) { }
    }
}
