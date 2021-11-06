using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace MyStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected ILogger<Controller> Logger => (ILogger<Controller>)HttpContext.RequestServices.GetService(typeof(ILogger<Controller>));
    }
}
