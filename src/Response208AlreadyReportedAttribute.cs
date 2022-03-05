using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes.ResponseTypes
{
    public class Response208AlreadyReportedAttribute : ProducesResponseTypeAttribute
    {
        public Response208AlreadyReportedAttribute(Type type) : base(type, StatusCodes.Status208AlreadyReported) { }
    }
}
