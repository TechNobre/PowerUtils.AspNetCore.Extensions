using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes.ResponseTypes
{
    public class Response410GoneAttribute : ProducesResponseTypeAttribute
    {
        public Response410GoneAttribute(Type type) : base(type, StatusCodes.Status410Gone) { }
    }
}
