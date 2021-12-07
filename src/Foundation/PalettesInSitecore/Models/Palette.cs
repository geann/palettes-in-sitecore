using Sitecore.Data;
namespace PalettesInSitecore.Models
{
    public class Palette
    {
        private Sitecore.Data.Items.Item _item;

        public virtual PaletteTheme PaletteTheme { get; set; }
        public virtual string BG
        {
            get
            {
                if (_item != null)
                    return _item.Fields[PaletteConstants.BGFieldName]?.Value;
                else
                    return string.Empty;
            }
        }

        public virtual string CTABG
        {
            get
            {
                if (_item != null)
                    return _item.Fields[PaletteConstants.CTABGFieldName]?.Value;
                else
                    return string.Empty;
            }
        }
        public virtual string CTAText
        {
            get
            {
                if (_item != null)
                    return _item.Fields[PaletteConstants.CTATextFieldName]?.Value;
                else
                    return string.Empty;
            }
        }
        public virtual string PaletteKey
        {
            get
            {
                if (_item != null)
                    return _item.Name.ToLower();
                else
                    return string.Empty;
            }
        }

        public Palette(string Id)
        {
            _item = Sitecore.Context.Database.Items.GetItem(Id);
        }
        public Palette(ID Id)
        {
            _item = Sitecore.Context.Database.Items.GetItem(Id);
        }
        public Palette(Sitecore.Data.Items.Item item)
        {
            _item = item;
        }
    }
    public static partial class PaletteConstants
    {
        public const string DefaultTheme = "Default";
        public static readonly string DefaultThemeKey = DefaultTheme.ToLower();

        public const string PaletteFolderIdString = "{8074405D-C728-4931-B585-4DA253E8AF92}";
        public static readonly ID PaletteFolderId = new ID(PaletteFolderIdString);

        public const string BGFieldName = "BG";
        public const string CTABGFieldName = "CTA BG";
        public const string CTATextFieldName = "CTA Text";
    }
}