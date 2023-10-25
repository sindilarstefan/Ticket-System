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
    /// <summary>
    /// Interaction logic for SignUP.xaml
    /// </summary>
    public partial class SignUP : Page
    {
        public NavigationService BackNavigationService { get; set; }
        public SignUP()
        {
            InitializeComponent();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button Clicked!");
           
        }
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Cont creat cu succes!");

            //Console.WriteLine("DAAAAA");

            // if (this.NavigationService != null && this.NavigationService.CanGoBack)
            //{
            //  NavigationService.GoBack();


            //}
            //else
            //  Console.WriteLine("it is null\n");
            mainFrame.Content = null;
            PagPrincipala pag = new PagPrincipala();
            //signupPage.BackNavigationService = mainFrame.NavigationService;
            mainFrame.NavigationService.Navigate(pag);
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void mainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void mainFrame_Navigated_1(object sender, NavigationEventArgs e)
        {

        }
        private void Departament_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }
        
    }
}
