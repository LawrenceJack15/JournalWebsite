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

namespace JournalWebsite
{
    /// <summary>
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Window
    {
        public RegisterPage()
        {
            InitializeComponent();
        }
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            Access reg = new Access();
            bool validation;
            validation = reg.register(name.Text.Trim(), pass.Text.Trim());
            if (validation == true)
            {
                MessageBox.Show("Next Step");
            }
            else
            {
                taken.Foreground.Opacity = 100;
            }

        }

    }
}
