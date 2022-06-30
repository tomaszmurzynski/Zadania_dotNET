﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace Zadania_dotNET
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Model model = new Model();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = model;
        }

        private void Szczegóły(object sender, RoutedEventArgs e)
        {
            ListBox lista = (ListBox)this.FindName("ListaFilmow");
            Film wybrana = (Film)lista.SelectedItem;
            new OknoSzczegółów(wybrana).Show();
        }

        private void NowyElement(object sender, RoutedEventArgs e)
        {
            Film nowy = model.NowyElement();
            new OknoSzczegółów(nowy).Show();


            /*Osoba nowa = model.NowaOsoba();
            new OknoSzczegółów(nowa).Show();*/

            //new OknoSzczegółów(model.NowyElement()).Show();
        }
    }
}
