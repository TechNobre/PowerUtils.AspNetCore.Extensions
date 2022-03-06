using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response201CreatedAttribute : ProducesResponseTypeAttribute
    {
        public Response201CreatedAttribute(Type type) : base(type, StatusCodes.Status201Created) { }
    }
}
