﻿using System;

namespace FridgeWPF.ConcreteIngredients
{
    /// <summary>
    /// Concrete ingredient.
    /// </summary>
    public class Tomatoes : AbstractIngredient
    {
        public Tomatoes(double amount) : base(amount)
        {
        }

        public Tomatoes(double amount, DateTime expiryDate) : base(amount, expiryDate)
        {
        }

        public override string Unit => "kg";
    }
}
