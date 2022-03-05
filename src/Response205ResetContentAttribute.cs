using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes.ResponseTypes
{
    public class Response205ResetContentAttribute : ProducesResponseTypeAttribute
    {
        public Response205ResetContentAttribute(Type type) : base(type, StatusCodes.Status205ResetContent) { }
    }
}
