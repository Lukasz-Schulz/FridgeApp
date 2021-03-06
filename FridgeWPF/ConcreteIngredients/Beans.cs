﻿using System;

namespace FridgeWPF.ConcreteIngredients
{
    /// <summary>
    /// Concrete ingredient.
    /// </summary>
    public class Beans : AbstractIngredient
    {
        public Beans(double amount) : base(amount)
        {
        }

        public Beans(double amount, DateTime expiryDate) : base(amount, expiryDate)
        {
        }

        public override string Unit => "kg";
    }
}
