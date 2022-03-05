using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes.ResponseTypes
{
    public class Response206PartialContentAttribute : ProducesResponseTypeAttribute
    {
        public Response206PartialContentAttribute(Type type) : base(type, StatusCodes.Status206PartialContent) { }
    }
}
