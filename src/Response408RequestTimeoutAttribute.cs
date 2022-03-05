using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes.ResponseTypes
{
    public class Response408RequestTimeoutAttribute : ProducesResponseTypeAttribute
    {
        public Response408RequestTimeoutAttribute(Type type) : base(type, StatusCodes.Status408RequestTimeout) { }
    }
}
