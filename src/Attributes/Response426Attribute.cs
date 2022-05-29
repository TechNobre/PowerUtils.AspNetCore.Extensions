using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Response with status code 426 (UpgradeRequired)
    /// </summary>
    public class Response426Attribute : ProducesResponseTypeAttribute
    {
        public Response426Attribute(Type type) : base(type, StatusCodes.Status426UpgradeRequired) { }
    }
}
