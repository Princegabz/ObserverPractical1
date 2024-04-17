namespace DecoratorBeverageExample
{
    // Concrete implementation of Beverage for Tea
    internal class Tea : Beverage //ConcreteComponent
    {
        //Operations
        public override string GetDescription()
        {
            return "Tea";
        }
    }
}