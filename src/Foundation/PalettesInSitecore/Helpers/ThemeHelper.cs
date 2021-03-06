using PalettesInSitecore.Models;
using Sitecore.Mvc.Presentation;

namespace PalettesInSitecore.Helpers
{
    public static class ThemeHelper
    {
        public static string GetComponentTheme()
        {
            string paletteKey = GetComponentPaletteKey();
            if (string.IsNullOrEmpty(paletteKey))
            {
                paletteKey = GetPagePaletteKey();
            }
            return $"theme-{paletteKey}".ToLower();
        }
        private static string GetPaletteKey(Palette palette)
        {
            if (palette != null)
            {
                return palette.PaletteKey;
            }

            return GetPagePaletteKey();
        }
        private static string GetPagePaletteKey()
        {
            Sitecore.Data.Items.Item item = Sitecore.Context.Item;
            string paletteId = item?.Fields["Palette"]?.Value;
            if (!string.IsNullOrEmpty(paletteId))
            {
                Palette palette = new Palette(paletteId);
                return GetPaletteKey(palette);
            }

            return string.Empty;
        }
        private static string GetComponentPaletteKey()
        {
            Sitecore.Data.Items.Item item = RenderingContext.Current.Rendering.Item; 
            string paletteId = item?.Fields["Palette"]?.Value;
            if (!string.IsNullOrEmpty(paletteId))
            {
                Palette palette = new Palette(paletteId);
                return GetPaletteKey(palette);
            }

            return string.Empty;
        }
    }
}