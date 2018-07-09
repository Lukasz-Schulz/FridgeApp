using System;

namespace FridgeWPF.ConcreteIngredients
{
    /// <summary>
    /// Concrete ingredient.
    /// </summary>
    public class Cabbage : AbstractIngredient
    {
        public Cabbage(double amount) : base(amount)
        {
        }

        public Cabbage(double amount, DateTime expiryDate) : base(amount, expiryDate)
        {
        }

        public override string Unit => "kg";
    }
}
