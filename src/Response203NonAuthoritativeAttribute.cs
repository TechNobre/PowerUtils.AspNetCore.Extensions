using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes.ResponseTypes
{
    public class Response203NonAuthoritativeAttribute : ProducesResponseTypeAttribute
    {
        public Response203NonAuthoritativeAttribute(Type type) : base(type, StatusCodes.Status203NonAuthoritative) { }
    }
}
