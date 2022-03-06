using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response402PaymentRequiredAttribute : ProducesResponseTypeAttribute
    {
        public Response402PaymentRequiredAttribute(Type type) : base(type, StatusCodes.Status402PaymentRequired) { }
    }
}
