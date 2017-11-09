using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bartender
{
    public class EnumContainer
    {
        public enum Type { Null, Recipe, Drink, Both  };
        public enum ReservedSymbols { Delimiter = '^' };
        public enum MenuItemColumns { Name, Type, NumSteps, Path, Active };
        public enum StepsColumns { Name, StepNum, Description, Active };
        public enum IngredientColumns { Name, Ingredient, UnitCount, Unit, Active}
        public enum Statements { SELECT };
        public enum TableName { MenuItem, Steps, Ingredients};
        public enum ActivityLevel { Null, Active, Inactive };
    }
}
