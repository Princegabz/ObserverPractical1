namespace DecoratorBeverageExample
{
    // Concrete implementation of Beverage for BlackCoffee
    class BlackCoffee : Beverage //ConcreteComponent
    {
        //Operations
        public override string GetDescription() // Overrides the GetDescription method to return a description for BlackCoffee
        {
            return "Black Coffee";
        }
    }
}