using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response410GoneAttribute : ProducesResponseTypeAttribute
    {
        public Response410GoneAttribute(Type type) : base(type, StatusCodes.Status410Gone) { }
    }
}
