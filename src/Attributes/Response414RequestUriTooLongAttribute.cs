using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response414RequestUriTooLongAttribute : ProducesResponseTypeAttribute
    {
        public Response414RequestUriTooLongAttribute(Type type) : base(type, StatusCodes.Status414RequestUriTooLong) { }
    }
}
