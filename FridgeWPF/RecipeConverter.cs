﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FridgeWPF
{
    /// <summary>
    /// Contains methods converting recipes to string and strings to recipes
    /// </summary>
    public class RecipeConverter //zawiera metody konwertujące przepisy z klasy AbstractRecipe na string i odwrotnie 
                                        //(w celu dopasowania ich do struktury bazy danych)
    {
        public List<AbstractIngredient> FromStringToListOfIngredients(string input)//metoda dopasowująca poszczególne elementy
        {                                                                           //stringa do odpowiednich właściwości
                                                                                    //klasy ingredient
            try
            {
                List<AbstractIngredient> list = new List<AbstractIngredient>();
                string[] listAsArray = input.Split(' ', ';', '\n');//metoda rozdziela poszczególne składniki na podstawie wymienionych
                                                                   //separatorów
                foreach (string AB in listAsArray)
                {
                    string[] recipeAsArray = AB.Split('-');//metoda rozdziela parametry składnika wymienione po myślnikach
                    list.Add(FactoryPicker.Instance.Pick(recipeAsArray[0]).Create(Convert.ToDouble(recipeAsArray[1])));
                    //tworzony jest składnik, a następnie umieszcza się go na liście
                }
                return list;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Wrong input string format. Cannot convert to recipe.");
                return new List<AbstractIngredient>();
            }
        }

        /// <summary>
        /// Writes down all the content of passed ingredient and returns it as a string.
        /// </summary>
        /// <param name="ingredient"></param>
        /// <returns></returns>
        public string FromIngredientToString(AbstractIngredient ingredient)//metoda tworząca string gotowy do umieszczenia na 
        {                                                                   //listBoxie
            string output = ingredient.Name + "-" + ingredient.Amount.ToString();//metoda rozdziela poszczególne składowe składnika
            return output;
        }

    }
}
