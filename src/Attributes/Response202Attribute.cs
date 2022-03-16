using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    public class Response202Attribute : ProducesResponseTypeAttribute
    {
        public Response202Attribute() : base(StatusCodes.Status202Accepted) { }
        public Response202Attribute(Type type) : base(type, StatusCodes.Status202Accepted) { }
    }
}
