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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Algoritms;

namespace AlgorithmsSort
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Boolean clickBubble, clickCocktail, clickInsert;

        private void Sort_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuBubble_Click(object sender, RoutedEventArgs e)
        {
            clickBubble = true;
            clickCocktail = false;
            clickInsert = false;
        }

        private void MenuCocktail_Click(object sender, RoutedEventArgs e)
        {
            clickBubble = false;
            clickCocktail = true;
            clickInsert = false;
        }

        private void MenuInsert_Click(object sender, RoutedEventArgs e)
        {
            clickBubble = false;
            clickCocktail = true;
            clickInsert = false;
        }
    }
}
