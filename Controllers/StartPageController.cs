using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EpiBloggMax.Models.Pages;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web.Mvc;
using EPiServer.Framework.DataAnnotations;

namespace EpiBloggMax.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        public ActionResult Index(StartPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return View(currentPage);
        }
    }
}