using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace KaffePTCloud.Core.Controllers
{
    public class SiteLayoutController : SurfaceController
    {
        public ActionResult _Head() => PartialView("~/Views/Partials/SiteLayout/_Head.cshtml");
        public ActionResult _Header() => PartialView("~/Views/Partials/SiteLayout/_Header.cshtml");
        public ActionResult _Footer() => PartialView("~/Views/Partials/SiteLayout/_Footer.cshtml");
        public ActionResult _Scripts() => PartialView("~/Views/Partials/SiteLayout/_Scripts.cshtml");


    }
}