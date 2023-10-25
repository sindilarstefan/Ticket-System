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

namespace ATM_Tiketing
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        private void TiketsButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = null;
            TabelTichete tabel = new TabelTichete();
           // tabel.BackNavigationService = mainFrame.NavigationService;
            mainFrame.NavigationService.Navigate(tabel);
            //CreareContNou.Visibility = Visibility.Collapsed;
        }
        private void DelogareButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow wn = new MainWindow();
            wn.Show();
            this.Close();
        }
        private void Draw_Sin_Click(object sender, RoutedEventArgs e)
        {
            // Get canvas dimensions
            //double canvasWidth = canvas.ActualWidth;
            //double canvasHeight = canvas.ActualHeight;

            //// Clear previous drawings on the canvas
            //canvas.Children.Clear();

            //// Define parameters for the sine wave
            //double amplitude = 100;
            //double frequency = 1;
            //double phaseShift = 0;

            //// Draw the sine wave on the canvas
            //for (double x = 0; x < canvasWidth; x += 1)
            //{
            //    double y = amplitude * Math.Sin(2 * Math.PI * frequency * x / canvasWidth + phaseShift) + canvasHeight / 2;

            //    // Draw a line segment for the sine wave
            //    Line lineSegment = new Line
            //    {
            //        X1 = x,
            //        Y1 = y,
            //        X2 = x + 1,
            //        Y2 = amplitude * Math.Sin(2 * Math.PI * frequency * (x + 1) / canvasWidth + phaseShift) + canvasHeight / 2,
            //        Stroke = Brushes.Blue,
            //        StrokeThickness = 1
            //    };

            //    // Add the line segment to the canvas
            //    canvas.Children.Add(lineSegment);
            //}
        }

    }
}
