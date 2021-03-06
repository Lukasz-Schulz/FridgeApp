﻿using System;

namespace FridgeWPF.ConcreteIngredients
{
    /// <summary>
    /// Concrete ingredient.
    /// </summary>
    public class Peas : AbstractIngredient
    {
        public Peas(double amount) : base(amount)
        {
        }

        public Peas(double amount, DateTime expiryDate) : base(amount, expiryDate)
        {
        }

        public override string Unit => "kg";
    }
}
