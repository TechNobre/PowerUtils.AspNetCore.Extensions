using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response202AcceptedAttribute : ProducesResponseTypeAttribute
    {
        public Response202AcceptedAttribute(Type type) : base(type, StatusCodes.Status202Accepted) { }
    }
}
