using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Mammals : Animal
    {
        private MammalType type { get; }
        public Mammals(MammalType type)
        {
            this.type = type;
            Name = type.ToString();
        }   

        public override string MakesSound()
        {
            switch (type)
            {
                case MammalType.Dog: return "ham-ham";
                case MammalType.Cat: return "Meow";
                case MammalType.Horse: return "Diha-haha";

                default: throw new NotImplementedException();
            }
        }
    }

    public enum MammalType
    {
        Dog,    
        Cat,
        Horse
    }
}

