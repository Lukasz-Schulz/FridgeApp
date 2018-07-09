using FridgeWPF.ConcreteIngredients;
using System;

namespace FridgeWPF
{
    /// <summary>
    /// Concrete ingredient factory.
    /// </summary>
    public class TomatoesFactory : AbstractIngredientFactory
    {
        public override string Name { get; protected set; } = "Tomatoes";

        public override AbstractIngredient Create(double amount, DateTime expiryDate)
        {
            return new Tomatoes(amount, expiryDate);
        }

        public override AbstractIngredient Create(double amount)
        {
            return new Tomatoes(amount);
        }
    }
}

