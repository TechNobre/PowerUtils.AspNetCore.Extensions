using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes.ResponseTypes
{
    public class Response409ConflictAttribute : ProducesResponseTypeAttribute
    {
        public Response409ConflictAttribute(Type type) : base(type, StatusCodes.Status409Conflict) { }
    }
}
