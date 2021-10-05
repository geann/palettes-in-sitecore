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

        public Hsl ConvertHex(string hex)
        {
            hex = hex.ToLowerInvariant();

            if (_converted.ContainsKey(hex))
            {
                return _converted[hex];
            }

            var match = _hexRegex.Match(hex);
            if (!match.Success)
            {
                _converted.Add(hex, null);
                return null;
            }

            var r = (double)int.Parse(match.Groups[1].Value, NumberStyles.HexNumber);
            var g = (double)int.Parse(match.Groups[2].Value, NumberStyles.HexNumber);
            var b = (double)int.Parse(match.Groups[3].Value, NumberStyles.HexNumber);

            r /= 255;
            g /= 255;
            b /= 255;

            var max = Math.Max(Math.Max(r, g), b);
            var min = Math.Min(Math.Min(r, g), b);

            var h = (max + min) / 2;
            var s = (max + min) / 2;
            var l = (max + min) / 2;

            if (Math.Abs(max - min) < double.Epsilon)
            {
                h = s = 0; // transparent, no colour
            }
            else
            {
                var d = max - min;
                s = l > 0.5 ? d / (2 - max - min) : d / (max + min);

                if (Math.Abs(max - r) < double.Epsilon)
                {
                    h = ((g - b) / d) + (g < b ? 6 : 0);
                }
                else if (Math.Abs(max - g) < double.Epsilon)
                {
                    h = ((b - r) / d) + 2;
                }
                else if (Math.Abs(max - b) < double.Epsilon)
                {
                    h = ((r - g) / d) + 4;
                }

                h /= 6;
            }

            var hInt = (int)Math.Round(360.0 * h);
            var sInt = (int)Math.Round(s * 100);
            var lInt = (int)Math.Round(l * 100);

            var result = new Hsl(hInt, sInt, lInt);
            _converted.Add(hex, result);
            return result;
        }

        public string Hsl(string hex)
        {
            return ConvertHex(hex)?.ToHslString() ?? hex;
        }
    }
}