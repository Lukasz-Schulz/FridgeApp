using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FridgeWPF
{
    /// <summary>
    /// Window allowing to change the database server by the user.
    /// </summary>
    public partial class Options : Window//okno umożliwiające zdalny wybór serwera
    {
        public MainWindow Window { get; } //przez okno główne Options ma dostęp do lodówki i narzędzi obsługujących bazę danych
        private bool IsDBDefault = true; // jeżeli IsDBDefault jest prawdziwe, użyte zostanie domyślny connection string

        public Options(MainWindow window)
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            this.Topmost = true;
            InitializeComponent();
            Window = window;
        }

        /// <summary>
        /// Creates new connectionstrig based on a form filled by user.
        /// </summary>
        private void SetConnectionString()//metoda tworząca nowy connection string na podstawie wypełnionego formularza
        {
            if(txtServerName.Text.Length>0 &&           //sprawdza, czy wszystkie pola są wypełnione
                txtDataBaseName.Text.Length > 0 &&
                txtUsername.Text.Length > 0 &&
                txtPassword.Password.Length > 0)
                {
                    Window.DataBase.SetDatabase //ustawia nowe parametry do łączenia z serwerem 
                    (txtServerName.Text,
                    txtDataBaseName.Text,
                    txtUsername.Text,
                    txtPassword.Password.ToString()
                    );
                MessageBox.Show("You have changed your server temporarily.");
            }
            else
            {
                MessageBox.Show("Please fill the form first.");
            }
        }

        /// <summary>
        /// Sets new connection string and blocks default connection string after clicing the button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetNewServer_Click(object sender, RoutedEventArgs e)//obsługuje przycisk zmieniający tymczasowo ustawienia 
        {                                                                   //bazy danych
            SetConnectionString();//wykorzystuje lokalną metodę do zmiany parametrów connection stringa
            IsDBDefault = false;  //dzięki zmianie stanu na false  - nie zostanie wybrana domyślna baza danych                                                              
            Close();    //zamyka okno po wykonaniu zadania
        }

        /// <summary>
        /// Sets the default database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDefault_Click(object sender, RoutedEventArgs e)//ustawia domyślną bazę danych dla aplikacji i zamyka okno
        {
            SetDefaultDatabase();
            Close();
        }

        /// <summary>
        /// Sets the default database if the window is being closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)//przy braku jakichkolwiek ustawień,
        {                                                                                     //ustawia domyślną baze danych
            if (IsDBDefault == true)
            {                                                                                  
                MessageBox.Show("Database is set to default.");

                SetDefaultDatabase();
            }
        }

        /// <summary>
        /// Sets default connectionstring.
        /// </summary>
        void SetDefaultDatabase()//ustawia domyślną bazę danych dla aplikacji
        {
            Window.DataBase = new MySqlDataBase();//tworzy nową instancję bazy danych
            Window.DataBase.SetDatabase("sql11.freesqldatabase.com", "sql11227333", "sql11227333", "F48xDrZZcw");
                                                                //podaje parametry do połączenia
            Window.IsEnabled = true;//odblokowuje ekran
            Window.RefreshPage();
        }
    }
}
