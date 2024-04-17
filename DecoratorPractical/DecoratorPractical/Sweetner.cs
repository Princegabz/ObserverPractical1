using DecoratorPractical;

namespace DecoratorBeverageExample
{
    // Concrete decorator for adding Sweetner to beverages
    class Sweetner : CondimentDecorator//ConcreteDecorator
    {
        Beverage beverage;
        public Sweetner(Beverage beverage) : base(beverage) // Constructor to set the beverage object
        {
            this.beverage = beverage;
        }
        public override string GetDescription()  // Overrides the GetDescription method to add Milk to the description
        {
            return beverage.GetDescription() + " and Sweetner";
        }
    }
}