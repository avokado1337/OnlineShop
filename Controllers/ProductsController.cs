using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace Online_Shop.Controllers
{
    public class ProductsController : Controller
    {
        public IHttpActionResult Index()
        {
            return View();
        }
    }
}
