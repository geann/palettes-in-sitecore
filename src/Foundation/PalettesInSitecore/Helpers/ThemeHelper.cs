using PalettesInSitecore.Models;

namespace PalettesInSitecore.Helpers
{
    public static class ThemeHelper
    {
        private static string GetPaletteKey(Palette palette)
        {
            var activePalette = GetActivePalette(palette);

            return activePalette?.PaletteKey ?? string.Empty;
        }
        private static Palette GetActivePalette(Palette palette)
        {
            if (palette != null)
            {
                return palette;
            }

            return GetPagePalette();
        }
        private static Palette GetPagePalette()
        {
            Sitecore.Data.Items.Item item = Sitecore.Context.Item;
            if (item == null)
            {
                return null;
            }

            Palette palette = new Palette(item.Fields["Palette"].Value);
            if (palette != null)
            {
                return palette;
            }

            return null;
        }
    }
}