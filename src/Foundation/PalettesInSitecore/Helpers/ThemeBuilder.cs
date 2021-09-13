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

            List<Sitecore.Data.Items.Item> Palettes = PaletteSelectionItem.GetChildren().ToList();


            foreach (Sitecore.Data.Items.Item paletteItem in Palettes)
            {
                themeCss += BuildTheme(new Palette(paletteItem));
            }

            return themeCss;
        }
        private string BuildTheme(Palette palette)
        {
            string paletteCss = string.Empty;

            return paletteCss;
        }
    }
}