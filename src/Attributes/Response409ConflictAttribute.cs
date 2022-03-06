using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response409ConflictAttribute : ProducesResponseTypeAttribute
    {
        public Response409ConflictAttribute(Type type) : base(type, StatusCodes.Status409Conflict) { }
    }
}
