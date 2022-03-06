using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    public class Response407Attribute : ProducesResponseTypeAttribute
    {
        public Response407Attribute(Type type) : base(type, StatusCodes.Status407ProxyAuthenticationRequired) { }
    }
}
