using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    public class Response206Attribute : ProducesResponseTypeAttribute
    {
        public Response206Attribute(Type type) : base(type, StatusCodes.Status206PartialContent) { }
    }
}
