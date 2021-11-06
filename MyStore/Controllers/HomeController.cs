using System;
using Application;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Application.ViewModels;

namespace MyStore.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController()
        {

        }

        public OkResult Index()
        {
            return Ok();
        }

    }
}
