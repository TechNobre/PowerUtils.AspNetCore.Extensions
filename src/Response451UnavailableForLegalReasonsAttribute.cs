﻿using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes.ResponseTypes
{
    public class Response451UnavailableForLegalReasonsAttribute : ProducesResponseTypeAttribute
    {
        public Response451UnavailableForLegalReasonsAttribute(Type type) : base(type, StatusCodes.Status451UnavailableForLegalReasons) { }
    }
}