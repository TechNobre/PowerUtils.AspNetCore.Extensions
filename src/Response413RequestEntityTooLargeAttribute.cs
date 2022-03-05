using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes.ResponseTypes
{
    public class Response413RequestEntityTooLargeAttribute : ProducesResponseTypeAttribute
    {
        public Response413RequestEntityTooLargeAttribute(Type type) : base(type, StatusCodes.Status413RequestEntityTooLarge) { }
    }
}
