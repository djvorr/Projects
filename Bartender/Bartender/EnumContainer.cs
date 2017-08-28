using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bartender
{
    public class EnumContainer
    {
        public enum Type { Recipe, Drink, Both };
        public enum ReservedSymbols { Delimiter = '^' };
        public enum Columns { Index, Location, StepNumber, Step };
        public enum Statements { SELECT };
    }
}
