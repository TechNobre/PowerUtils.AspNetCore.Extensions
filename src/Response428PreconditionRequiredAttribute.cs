using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes.ResponseTypes
{
    public class Response428PreconditionRequiredAttribute : ProducesResponseTypeAttribute
    {
        public Response428PreconditionRequiredAttribute(Type type) : base(type, StatusCodes.Status428PreconditionRequired) { }
    }
}
