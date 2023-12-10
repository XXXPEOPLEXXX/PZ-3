using Pz3_Mebel.Models;
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

namespace Pz3_Mebel.Pages
{
    /// <summary>
    /// Логика взаимодействия для MebelPage.xaml
    /// </summary>
    public partial class MebelPage : Page
    {
        public MebelPage()
        {
            InitializeComponent();
            DGMebel.ItemsSource = App.DB.Mebel.ToList();
        }

        private void BtnAddMebel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddMebelPage(new Mebel()));
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            var selectedMebel = DGMebel.SelectedItem as Mebel;
            if(selectedMebel == null)
            {
                MessageBox.Show("Выберите мебель!");
                return;
            }
            NavigationService.Navigate(new AddMebelPage(selectedMebel));
        }

        private void BtnDeleteMebel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
