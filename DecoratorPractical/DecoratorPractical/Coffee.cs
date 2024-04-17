namespace DecoratorBeverageExample
{
    // Concrete implementation of Beverage for Coffee
    internal class Coffee : Beverage //ConcreteComponent
    {
        //Operations
        public override string GetDescription() // Overrides the GetDescription method to return a description for Coffee
        {
            return "Coffee";
        }
    }
}