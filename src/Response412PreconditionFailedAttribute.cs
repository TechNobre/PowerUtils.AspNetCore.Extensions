using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes.ResponseTypes
{
    public class Response412PreconditionFailedAttribute : ProducesResponseTypeAttribute
    {
        public Response412PreconditionFailedAttribute(Type type) : base(type, StatusCodes.Status412PreconditionFailed) { }
    }
}
