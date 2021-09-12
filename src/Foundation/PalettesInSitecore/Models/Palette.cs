namespace PalettesInSitecore.Models
{
    public class Palette
    {
        public virtual PaletteTheme PaletteTheme { get; set; }
        public virtual string BG { get; set; }
        public virtual string CTABG { get; set; }
    }
}