using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace FridgeWPF
{
    /// <summary>
    /// An interface for the database handlers.
    /// </summary>
    public abstract class OnlineDataBase
    {
        public RecipeConverter Converter { get; protected set; } = new RecipeConverter();
        public abstract string ConnectionString { get; protected set; }
        public System.Data.Common.DbConnection Connection;
        public System.Data.Common.DbCommand Command { get; set; }

        public string ServerName { get; protected set; }
        public string DataBaseName { get; protected set; }
        public string Username { get; protected set; }
        public string Password { get; protected set; }

        public abstract void AddRecipeToDatabase(AbstractRecipe recipe);

        public abstract void AddIngredientToDatabase(AbstractIngredient ingredient);

        public abstract void DeleteIngredientFromDatabase(AbstractIngredient ingredient);

        /// <summary>
        /// Creates connection string for the new database.
        /// </summary>
        /// <param name="server"></param>
        /// <param name="dataBase"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public void SetDatabase(string server, string dataBase, string username, string password)
        {
            ServerName = server;
            DataBaseName = dataBase;
            Password = password;
            Username = username;

            ConnectionString = $"Server={ServerName}; " +
                                    $"Database={DataBaseName}; " +
                                    $"Uid={Username}; " +
                                    $"Pwd={Password};";
        }
    }
}