using Sitecore.Data;
namespace PalettesInSitecore.Models
{
    public class Palette
    {
        public virtual PaletteTheme PaletteTheme { get; set; }
        public virtual string BG { get; set; }
        public virtual string CTABG { get; set; }
    }
    public static partial class PaletteConstants
    {
        public const string DefaultTheme = "Default";
        public static readonly string DefaultThemeKey = DefaultTheme.ToLower();

        public const string PaletteFolderIdString = "{8074405D-C728-4931-B585-4DA253E8AF92}";
        public static readonly ID PaletteFolderId = new ID(PaletteFolderIdString);
    }
}