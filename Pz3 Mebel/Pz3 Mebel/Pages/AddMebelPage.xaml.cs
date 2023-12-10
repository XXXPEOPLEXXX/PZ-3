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
    /// Логика взаимодействия для AddMebelPage.xaml
    /// </summary>
    
    public partial class AddMebelPage : Page
    {
        Mebel contextMebel;
        public AddMebelPage(Mebel mebel)
        {
            InitializeComponent();
            contextMebel = mebel;
            DataContext = contextMebel;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (contextMebel.IdMebel == 0)
                App.DB.Mebel.Add(contextMebel);
            App.DB.SaveChanges();
            NavigationService.GoBack();
            
        }
    }
}
