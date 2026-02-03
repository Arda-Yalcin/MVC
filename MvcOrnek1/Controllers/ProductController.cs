using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MvcOrnek1.Controllers;

    public class ProductController : Controller
    {

        public IActionResult Urun()
        {
            return View();
        }

    }