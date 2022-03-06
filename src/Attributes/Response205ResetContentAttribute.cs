using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response205ResetContentAttribute : ProducesResponseTypeAttribute
    {
        public Response205ResetContentAttribute(Type type) : base(type, StatusCodes.Status205ResetContent) { }
    }
}
