using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes
{
    /// <summary>
    /// Response with status code 204 (NoContent)
    /// </summary>
    public class Response204Attribute : ProducesResponseTypeAttribute
    {
        public Response204Attribute() : base(StatusCodes.Status204NoContent) { }
    }
}
