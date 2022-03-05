using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes.ResponseTypes
{
    public class Response200OKAttribute : ProducesResponseTypeAttribute
    {
        public Response200OKAttribute(Type type) : base(type, StatusCodes.Status200OK) { }
    }
}
