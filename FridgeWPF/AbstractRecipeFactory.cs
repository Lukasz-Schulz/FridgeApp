using System.Collections.Generic;

namespace FridgeWPF
{
    /// <summary>
    /// Abstract factory creating recipes.
    /// </summary>
    public abstract class AbstractRecipeFactory//abstrakcyjna wersja fabryki przepisów
    {
        public abstract AbstractRecipe CreateRecipe(string name, List<AbstractIngredient> listOfIngredients, 
                                                        string description);
    }
}
