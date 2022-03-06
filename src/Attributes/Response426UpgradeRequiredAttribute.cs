using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response426UpgradeRequiredAttribute : ProducesResponseTypeAttribute
    {
        public Response426UpgradeRequiredAttribute(Type type) : base(type, StatusCodes.Status426UpgradeRequired) { }
    }
}
