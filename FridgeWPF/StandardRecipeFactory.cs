using System.Collections.Generic;

namespace FridgeWPF
{
    /// <summary>
    /// Concrete factory for producing standard recipes.
    /// </summary>
    public class StandardRecipeFactory : AbstractRecipeFactory //konkretna fabryka składników o braku dodatkowych właściwości
    {
        /// <summary>
        /// Creates recipes without any additional features.
        /// </summary>
        public override AbstractRecipe CreateRecipe(string name, List<AbstractIngredient> listOfIngredients, string description)
        {
            return new StandardRecipe(name, listOfIngredients, description);
        }
    }
}
