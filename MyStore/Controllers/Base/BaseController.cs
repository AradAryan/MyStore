using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace MyStore.Controllers
{
    public class BaseController : Controller
    {
        //protected StoreDbContext Context => (StoreDbContext)HttpContext.RequestServices.GetService(typeof(StoreDbContext));
        protected ILogger<Controller> Logger => (ILogger<Controller>)HttpContext.RequestServices.GetService(typeof(ILogger<Controller>));

    }
}
