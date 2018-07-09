using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeWPF
{
    /// <summary>
    /// An interface providing a class with a Recipebook.
    /// </summary>
    public interface IRecipeBook // interfejs wymuszający posiadanie listy przepisów o nazwie Recipebook
    {
        List<AbstractRecipe> Recipebook { get; }
    }
}
