using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Response with status code 201 (Created)
    /// </summary>
    public class Response201Attribute : ProducesResponseTypeAttribute
    {
        public Response201Attribute() : base(StatusCodes.Status201Created) { }
        public Response201Attribute(Type type) : base(type, StatusCodes.Status201Created) { }
    }
}
