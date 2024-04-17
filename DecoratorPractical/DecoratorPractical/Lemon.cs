using DecoratorPractical;

namespace DecoratorBeverageExample
{
    // Concrete decorator for adding lemon to beverages
    class Lemon : CondimentDecorator//ConcreteDecorator
    {
        Beverage beverage;
        public Lemon(Beverage beverage) : base(beverage) // Constructor to set the beverage object
        {
            this.beverage = beverage;
        }
        public override string GetDescription()  // Overrides the GetDescription method to add Milk to the description
        {
            return beverage.GetDescription() + " and Lemon";
        }
    }
}
