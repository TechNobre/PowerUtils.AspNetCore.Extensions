﻿using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response205Attribute : ProducesResponseTypeAttribute
    {
        public Response205Attribute(Type type) : base(type, StatusCodes.Status205ResetContent) { }
    }
}
