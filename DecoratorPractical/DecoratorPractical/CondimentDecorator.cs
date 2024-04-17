using DecoratorBeverageExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPractical
{
    // Decorator class for adding condiments to beverages
    abstract class CondimentDecorator : Beverage //DecoratorBase
    {
        Beverage Beverage = null;
        public CondimentDecorator(Beverage beverage) // Constructor to set the beverage object
        {
            this.Beverage = beverage;
        }
        public override string GetDescription()
        {
            return Beverage.GetDescription();
        }
    }
}
