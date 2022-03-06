using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response406NotAcceptableAttribute : ProducesResponseTypeAttribute
    {
        public Response406NotAcceptableAttribute(Type type) : base(type, StatusCodes.Status406NotAcceptable) { }
    }
}
