using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace KaffePTCloud.Core.Controllers
{
    public class SiteLayoutController : SurfaceController
    {
        public ActionResult _Head() => PartialView("~/Views/Partials/SiteLayout/_Head.cshtml");
        public ActionResult _Hegader() => PartialView("~/Views/Partials/SiteLayout/_Hegader.cshtml");
        public ActionResult _Footer() => PartialView("~/Views/Partials/SiteLayout/_Footer.cshtml");
        public ActionResult _Scripts() => PartialView("~/Views/Partials/SiteLayout/_Scripts.cshtml");


    }
}