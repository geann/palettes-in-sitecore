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

            return null;

        }
    }
}