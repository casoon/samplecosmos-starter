using System;
using Microsoft.AspNetCore.Mvc;

namespace SampleCosmos.Api.Controllers
{
    [ApiController]
    [ApiVersion("")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public abstract class BaseApiController : Controller
    {

    }

}
