
namespace PalettesInSitecore.Models
{
    public class Hsl
    {
        public Hsl(int h, int s, int l)
        {
            H = h;
            S = s;
            L = l;
        }

        public int H { get; }
        public int S { get; }
        public int L { get; }

        public bool IsDark => this.L < 49;

        public Hsl Darken(int lDelta)
        {
            var newL = L - lDelta;
            if (newL < 0)
            {
                newL = 0;
            }

            return new Hsl(H, S, newL);
        }
        public Hsl Lighten(int lDelta)
        {
            var newL = L + lDelta;
            if (newL > 100)
            {
                newL = 100;
            }

            return new Hsl(H, S, newL);
        }
        public string ToHslString()
        {
            return $"hsl({H}, {S}%, {L}%)";
        }
    }
}