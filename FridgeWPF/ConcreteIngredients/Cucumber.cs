﻿using System;

namespace FridgeWPF.ConcreteIngredients
{
    /// <summary>
    /// Concrete ingredient.
    /// </summary>
    public class Cucumber : AbstractIngredient
    {
        public Cucumber(double amount) : base(amount)
        {
        }

        public Cucumber(double amount, DateTime expiryDate) : base(amount, expiryDate)
        {
        }

        public override string Unit => "kg";
    }
}
