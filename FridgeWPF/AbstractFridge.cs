using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FridgeWPF.MainWindow;

namespace FridgeWPF
{
    /// <summary>
    /// Handles the list of ingredients from the database and subclasses which allows access to the database.
    /// </summary>
    public abstract class AbstractFridge //Lodówka/Magazyn posiada listę składników, które pobiera z bazy danych, a poza tym
                                        //zawiera klasy dostarczające metod umożliwiających dostęp do bazy danych
    {
        public MainWindowFridgeFiller Filler; //umożliwia konwersję składników na typ string i wypełnianie pól na ekranie głównym
        private NewIngredientSaver NewIngredient; // umożliwia tworzenie nowych instancji składników na podstawie ich parametrów
        public List<AbstractIngredient> Content { get; protected set; }//lista ze składnikami pochodząca z bazy danych
        public StateChecker StateCheck { get; private set; } //zawiera metody porównujące różne listy składników
        public MainWindow Window { get; }//dostęp do okna głównego potrzebny FridgeFillerowi do dostępu do pól

        public AbstractFridge(MainWindow window)
        {            
            StateCheck = new StateChecker(this);
            Window = window;
            Content = new List<AbstractIngredient>();
            Filler = new MainWindowFridgeFiller(this, window);
        }

        /// <summary>
        /// Adds an ingredient to local list.
        /// </summary>
        /// <param name="ingredient"></param>
        public void AddIngredient(AbstractIngredient ingredient) //umożliwia dodawanie składników na listę
        {
            Content.Add(ingredient);
        }

        /// <summary>
        /// /Adds an ingredient to the database.
        /// </summary>
        /// <param name="dataBase"></param>
        /// <param name="ingredientName"></param>
        /// <param name="amount"></param>
        /// <param name="expiryDate"></param>
        public void AddNewIngredientToDatabase(OnlineDataBase dataBase, string ingredientName, // dodaje nowy składnik do bazy
                                                double amount, DateTime expiryDate)             //wykorzystując klasę NewIngredient
        {
            NewIngredient = new NewIngredientSaver(dataBase);
            NewIngredient.AddNewIngredient(ingredientName, amount, expiryDate);
        }

        /// <summary>
        /// /Adds an ingredient to the database.
        /// </summary>
        /// <param name="dataBase"></param>
        /// <param name="ingredientName"></param>
        /// <param name="amount"></param>
        /// <param name="expiryDate"></param>
        public void AddNewIngredientToDatabase(OnlineDataBase dataBase, AbstractIngredient ingredient)//dodaje nowy składnik do bazy,
                                                                                            //wykorzystując klasę newIngredient,
                                                                                            //ale na podstawie klasy ingredient
        {                                                                                   //a nie poszczególnych składowych
            NewIngredient = new NewIngredientSaver(dataBase);
            NewIngredient.AddNewIngredient(ingredient.Name,ingredient.Amount, ingredient.ExpiryDate);
        }

        /// <summary>
        /// Deletes an ingredient from database and from the local list.
        /// </summary>
        /// <param name="dataBase"></param>
        /// <param name="ingredient"></param>
        public void DeleteIngredientFromDataBase(OnlineDataBase dataBase, AbstractIngredient ingredient)//usuwa wybrany składnik z 
        {                                                                                 //bazy danych wykorzystując narzędzia
            dataBase.DeleteIngredientFromDatabase(ingredient);                            //należące bezpośrednio do klasy database                
            Content.Remove(ingredient);                                                   //i usuwa je od razu z listy
        }

        /// <summary>
        /// Delegates a method which compares the local fridge list with the passed recipe list.
        /// </summary>
        /// <param name="recipe"></param>
        /// <returns></returns>
        public bool IsThereEnough(AbstractRecipe recipe)                                //deleguje metodę porównującą zawartość 
        {                                                                               //lodówki z listą z przepisu
            return StateCheck.Check(recipe);
        }
    }
}
