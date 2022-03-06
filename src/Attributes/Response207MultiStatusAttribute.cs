using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response207MultiStatusAttribute : ProducesResponseTypeAttribute
    {
        public Response207MultiStatusAttribute(Type type) : base(type, StatusCodes.Status207MultiStatus) { }
    }
}
