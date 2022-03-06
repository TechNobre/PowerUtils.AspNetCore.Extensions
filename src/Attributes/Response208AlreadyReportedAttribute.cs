using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response208AlreadyReportedAttribute : ProducesResponseTypeAttribute
    {
        public Response208AlreadyReportedAttribute(Type type) : base(type, StatusCodes.Status208AlreadyReported) { }
    }
}
