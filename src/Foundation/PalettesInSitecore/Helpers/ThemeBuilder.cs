using PalettesInSitecore.Models;
using System.Collections.Generic;
using System.Linq;
namespace PalettesInSitecore.Helpers
{
    public class ThemeBuilder
    {
        public string Build()
        {
            string themeCss = string.Empty;

            Sitecore.Data.Items.Item PaletteSelectionItem = Sitecore.Context.Database.Items.GetItem(PaletteConstants.PaletteFolderId);

            foreach (Sitecore.Data.Items.Item paletteItem in PaletteSelectionItem.GetChildren())
            {
                themeCss += BuildTheme(new Palette(paletteItem));
            }

            return themeCss;
        }
        private string BuildTheme(Palette palette)
        {
            string paletteCss = string.Empty;
            var themeBaseClass = $".theme-{palette.PaletteKey}";

            if (!string.IsNullOrEmpty(palette.BG))
            {
                paletteCss += $"{themeBaseClass} .theme-token-bg{{background-color:{palette.BG}}}";
            }

            return paletteCss;
        }
    }
}