namespace DecoratorBeverageExample
{
    // Concrete implementation of Beverage for Hotchocololate
    internal class Hotchocololate : Beverage //ConcreteComponent
    {
        //Operations
        public override string GetDescription() // Overrides the GetDescription method to return a description for Coffee
        {
            return "Hot Chocolate";
        }
    }
}