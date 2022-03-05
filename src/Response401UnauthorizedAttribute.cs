using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes.ResponseTypes
{
    public class Response401UnauthorizedAttribute : ProducesResponseTypeAttribute
    {
        public Response401UnauthorizedAttribute(Type type) : base(type, StatusCodes.Status401Unauthorized) { }
    }
}
