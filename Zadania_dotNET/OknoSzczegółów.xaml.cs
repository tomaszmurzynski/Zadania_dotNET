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


namespace Zadania_dotNET
{
    /// <summary>
    /// Logika interakcji dla klasy OknoSzczegółów.xaml
    /// </summary>
    public partial class OknoSzczegółów : Window
    {
        Model model = new Model();
        public OknoSzczegółów(Film film)
        {
            DataContext = film;
            InitializeComponent();
        }

        private void OK(object sender, RoutedEventArgs e)
        {
            
                //new OknoSzczegółów(model.NowyElement()).Show();
                model.ListaFilmow.Add(new Film((string)this.FindName("Tytul"), (string)this.FindName("Rezyser"), (string)this.FindName("Wydawca"), (string)this.FindName("Nosnik"), (DateTime)this.FindName("DataWydania")));
           
            this.Close();
        }
    }
}
