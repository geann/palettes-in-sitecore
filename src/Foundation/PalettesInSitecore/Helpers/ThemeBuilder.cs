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

            if (!string.IsNullOrEmpty(palette.CTABG))
            {
                var bg = $"background-color:{_colourConverter.Hsl(palette.CTABG)}";
                var borderColour = $"border-color:{_colourConverter.Hsl(palette.CTABG)}";

                paletteCss += $"{themeBaseClass} .theme-token-cta{{{bg};{borderColour}}}";
                paletteCss += $"{themeBaseClass} .theme-token-cta:hover{{background-color:{HslToHover(palette.CTABG, 15)};border-color:{HslToHover(palette.CTABG, 15)};}}";
            }
            return paletteCss;
        }
        private string HslToHover(string hex, int delta)
        {
            var hsl = _colourConverter.ConvertHex(hex);

            if (hsl == null)
            {
                return hex;
            }

            return (hsl.IsDark ? hsl.Lighten(delta) : hsl.Darken(delta))?.ToHslString() ?? hex;
        }
    }
}