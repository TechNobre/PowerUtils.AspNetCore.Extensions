using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes.ResponseTypes
{
    public class Response414RequestUriTooLongAttribute : ProducesResponseTypeAttribute
    {
        public Response414RequestUriTooLongAttribute(Type type) : base(type, StatusCodes.Status414RequestUriTooLong) { }
    }
}
