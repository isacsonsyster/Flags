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

namespace flags
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Apaknapp_Click(object sender, RoutedEventArgs e)
        {
            if (ApaText.Text == "Apa")
            {
                ApaText.Text = "Bepa";
                Apaknapp.Content = "Apa";
            }

            else if (ApaText.Text== "Bepa")
            {
                var newButton = new Button();
                newButton.Content = "Ny knapp";
                newButton.Height = 30;
                newButton.Width = 75;
                MainGrid.Children.Add(newButton);

            }
            else
            {
                ApaText.Text = "Apa";
                Apaknapp.Content = "Bepa";
            }

        }
    }
}
