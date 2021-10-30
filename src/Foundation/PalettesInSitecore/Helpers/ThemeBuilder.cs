using PalettesInSitecore.Models;
namespace PalettesInSitecore.Helpers
{
    public class ThemeBuilder
    {
        private readonly ColourConverter _colourConverter = new ColourConverter();

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
                paletteCss += $"{themeBaseClass} .theme-token-bg{{background-color:{_colourConverter.Hsl(palette.BG)}}}";
            }

            return paletteCss;
        }
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