using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Extensions.Attributes
{
    public class Response204NoContentAttribute : ProducesResponseTypeAttribute
    {
        public Response204NoContentAttribute() : base(StatusCodes.Status204NoContent) { }
    }
}
