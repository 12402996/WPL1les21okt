using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPL1les21okt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //1st commit to feat branch

            //oké van B verg
=======
            //ok van T
        }

        //Ze noemen me CODDEURDERRRRRqsdfjhkdvsqvsdfgv;

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            if (NameTextBox.Text.Equals("admin") && PasswordTextBox.Text.Equals("admin"))
            {
                InfoTextBlock.Text = "U wordt ingelogd.";
            }
        }

        private void LogOffButton_Click(object sender, RoutedEventArgs e)
        {
            {
                InfoTextBlock.Text = "";
            }
        }
    }
}