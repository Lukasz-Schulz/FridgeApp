﻿using System;

namespace FridgeWPF
{
    /// <summary>
    /// Concrete ingredient factory.
    /// </summary>
    public class EggFactory : AbstractIngredientFactory
    {
        public override string Name { get; protected set; } = "Egg";

        public override AbstractIngredient Create(double amount, DateTime expiryDate)
        {
            return new Egg(amount, expiryDate);
        }

        public override AbstractIngredient Create(double amount)
        {
            return new Egg(amount);
        }
    }
}

