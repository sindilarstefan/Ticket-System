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

namespace ATM_Tiketing
{
    public partial class PagPrincipala : Page
    {
        public PagPrincipala()
        {
            InitializeComponent();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void ContNouButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(new Uri("SignUP.xaml", UriKind.Relative));
            CreareContNou.Visibility = Visibility.Collapsed;
        }
          private void Autentificare_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Autentificare cu succes!");
            
            try
            {
                Window2 wn = new Window2();
                wn.Show();

                Window parentWindow = Window.GetWindow(this); 
                parentWindow?.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening new window: {ex.Message}");
            }
        }
    }
}
