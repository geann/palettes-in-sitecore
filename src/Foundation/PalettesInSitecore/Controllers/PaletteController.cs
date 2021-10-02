using System.Web.Mvc;
using PalettesInSitecore.Helpers;
using Sitecore.Mvc.Controllers;

namespace PalettesInSitecore.Controllers
{
    public class PaletteController : SitecoreController
    {
        public ActionResult PaletteStyles()
        {
            var theme = new ThemeBuilder().Build();
            return View("~/Views/PaletteStyles.cshtml", model: theme);
        }

    }
}