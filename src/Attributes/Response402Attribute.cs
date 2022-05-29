using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Response with status code 402 (PaymentRequired)
    /// </summary>
    public class Response402Attribute : ProducesResponseTypeAttribute
    {
        public Response402Attribute(Type type) : base(type, StatusCodes.Status402PaymentRequired) { }
    }
}
