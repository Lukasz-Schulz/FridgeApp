using System;

namespace FridgeWPF
{
    /// <summary>
    /// Concrete ingredient.
    /// </summary>
    public class Egg : AbstractIngredient
    {
        public Egg(double amount) : base(amount)
        {
        }

        public Egg(double amount, DateTime expiryDate)
            : base(amount, expiryDate) { }

        public override string Unit => "pcs.";
    }
}
