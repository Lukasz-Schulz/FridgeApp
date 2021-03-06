﻿using System;

namespace FridgeWPF
{
    /// <summary>
    /// Concrete ingredient factory.
    /// </summary>
    public class FlourFactory : AbstractIngredientFactory
    {
        public override string Name { get; protected set; } = "Flour";

        public override AbstractIngredient Create(double amount, DateTime expiryDate)
        {
            return new Flour(amount, expiryDate);
        }

        public override AbstractIngredient Create(double amount)
        {
            return new Flour(amount);
        }
    }
}
