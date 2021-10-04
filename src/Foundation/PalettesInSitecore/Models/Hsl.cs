
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
    }
}