using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{

    public class Birds : Animal
    {
        private BirdsType type { get; }
        public Birds(BirdsType type)
        {
            this.type = type;
            Name = type.ToString();
        }

        public override string MakesSound()
        {
            switch (type)
            {
                case BirdsType.Stork: return "taca-taca-taca";
                case BirdsType.Sirloin: return "cip-cip-cirip";
                case BirdsType.Woodpecker: return "cioc-cioc";

                default: throw new NotImplementedException();
            }
        }
    }

    public enum BirdsType
    {
        Stork,
        Sirloin,
        Woodpecker
    }
}
