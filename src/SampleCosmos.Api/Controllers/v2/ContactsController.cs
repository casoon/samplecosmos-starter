using System;
using Microsoft.AspNetCore.Mvc;

namespace SampleCosmos.Api.Controllers.v2
{
    [ApiVersion("2.0")]
    public class ContactsController : BaseApiController
    {
        public ContactsController()
        {
        }

        [HttpGet]
        public ActionResult Version()
        {
            return Ok("2.0");
        }
    }
}
