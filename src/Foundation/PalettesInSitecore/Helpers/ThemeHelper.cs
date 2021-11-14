using PalettesInSitecore.Models;

namespace PalettesInSitecore.Helpers
{
    public static class ThemeHelper
    {
        public static string GetComponentTheme()
        {
            string paletteKey = GetPagePaletteKey();
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
            return item?.Fields["Palette"].Value ?? string.Empty;
        }
    }
}