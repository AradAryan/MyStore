using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace MyStore.Controllers
{
    public class BaseController : Controller
    {
        protected ILogger<Controller> Logger => (ILogger<Controller>)HttpContext.RequestServices.GetService(typeof(ILogger<Controller>));
    }
}
