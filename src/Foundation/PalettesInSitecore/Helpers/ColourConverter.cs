using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using PalettesInSitecore.Models;

namespace PalettesInSitecore.Helpers
{
    public class ColourConverter
    {
        private const string HexPattern = @"(?i)^#?([a-f\d]{2})([a-f\d]{2})([a-f\d]{2})$(?-i)";
        private readonly Regex _hexRegex = new Regex(HexPattern);

        private readonly Dictionary<string, Hsl> _converted = new Dictionary<string, Hsl>();
    }
}