﻿using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Response with status code 226 (IMUsed)
    /// </summary>
    public class Response226Attribute : ProducesResponseTypeAttribute
    {
        public Response226Attribute() : base(StatusCodes.Status226IMUsed) { }
        public Response226Attribute(Type type) : base(type, StatusCodes.Status226IMUsed) { }
    }
}
