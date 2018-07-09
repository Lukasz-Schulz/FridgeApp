using System;

namespace FridgeWPF
{
    /// <summary>
    /// Concrete ingredient.
    /// </summary>
    public class Flour : AbstractIngredient
    {
        public Flour(double amount) : base(amount)
        {
        }

        public Flour(double amount, DateTime expiryDate)
            : base(amount, expiryDate) { }

        public override string Unit => "kg";
    }
}
