using System;
using Microsoft.AspNetCore.Mvc;

namespace SampleCosmos.Api.Controllers.v1
{

    [ApiVersion("1.0")]
    public class ContactsController : BaseApiController
    {
        public ContactsController()
        {
        }

        [HttpGet]
        public ActionResult Version()
        {
            return Ok("1.0");
        }
    }
}
