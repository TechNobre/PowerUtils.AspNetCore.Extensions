using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes.ResponseTypes
{
    public class Response411LengthRequiredAttribute : ProducesResponseTypeAttribute
    {
        public Response411LengthRequiredAttribute(Type type) : base(type, StatusCodes.Status411LengthRequired) { }
    }
}
