using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeWPF
{
    /// <summary>
    /// Abstract factory creating ingredients.
    /// </summary>
    public abstract class AbstractIngredientFactory //fabryka abstrakcyjna będąca szablonem dla konkretnych fabryk składników
                                                    //każdą, nowo dodaną fabrykę trzeba koniecznie dodać do konstruktora
                                                    //FactoryPickera, jeżeli ma być dostępna w jego liście dostępnych fabryk
    {
        public abstract string Name { get; protected set; } //nazwę fabryki tworzy się na podstawie nazwy konkretnego 
                                                            //składnika, który ma tworzyć
/// <summary>
/// Creates an ingredient with defined expiry date.
/// </summary>
/// <param name="amount"></param>
/// <param name="expiryDate"></param>
/// <returns></returns>
        public abstract AbstractIngredient Create(double amount, DateTime expiryDate); //metoda do tworzenia składników do lodówki

        /// <summary>
        /// Creates an ingredient without defined expiry date.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public abstract AbstractIngredient Create(double amount); //metoda do tworzenia składników do przepisów
    }
}
