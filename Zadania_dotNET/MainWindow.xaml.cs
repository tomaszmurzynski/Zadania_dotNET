using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zadania_dotNET
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Category> listCategory = new ObservableCollection<Category>();
        public MainWindow()
        {
            InitializeComponent();

            DataContext = this.GetListCategories();
        }

        public ObservableCollection<Category> GetListCategories()
        {
            listCategory.Add(new Category() { Id = 1, Name = "Samochody" });
            listCategory.Add(new Category() { Id = 2, Name = "Motocykle" });
            listCategory.Add(new Category() { Id = 3, Name = "Nieruchomości" });

            return listCategory;
        }

        private void ShowCategoryList(object sender, RoutedEventArgs e)
        {
            listCategory.Add(new Category());   
        }
    }


}
