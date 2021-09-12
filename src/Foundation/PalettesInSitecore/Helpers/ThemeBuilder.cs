using PalettesInSitecore.Models;
using System.Collections.Generic;
using System.Linq;
namespace PalettesInSitecore.Helpers
{
    public class ThemeBuilder
    {
        public string Build()
        {
            string theme = string.Empty;

            Sitecore.Data.Items.Item PaletteSelectionItem = Sitecore.Context.Database.Items.GetItem(PaletteConstants.PaletteFolderId);

            List<Sitecore.Data.Items.Item> Palettes = PaletteSelectionItem.GetChildren().ToList();

            return theme;
        }
    }
}