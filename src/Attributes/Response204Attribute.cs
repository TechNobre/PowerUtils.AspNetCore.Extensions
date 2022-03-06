using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response204Attribute : ProducesResponseTypeAttribute
    {
        public Response204Attribute() : base(StatusCodes.Status204NoContent) { }
    }
}
