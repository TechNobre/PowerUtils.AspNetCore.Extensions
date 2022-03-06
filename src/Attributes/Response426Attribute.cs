using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    public class Response426Attribute : ProducesResponseTypeAttribute
    {
        public Response426Attribute(Type type) : base(type, StatusCodes.Status426UpgradeRequired) { }
    }
}
