using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response414Attribute : ProducesResponseTypeAttribute
    {
        public Response414Attribute(Type type) : base(type, StatusCodes.Status414RequestUriTooLong) { }
    }
}
