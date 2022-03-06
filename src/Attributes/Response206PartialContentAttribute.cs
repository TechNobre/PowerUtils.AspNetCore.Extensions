using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response206PartialContentAttribute : ProducesResponseTypeAttribute
    {
        public Response206PartialContentAttribute(Type type) : base(type, StatusCodes.Status206PartialContent) { }
    }
}
