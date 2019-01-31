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
    public partial class addJournalEntry : Window
    {
        public addJournalEntry()
        {
            InitializeComponent();
        }

        private void submitButton(object sender, RoutedEventArgs e)
        {
            JournalClass addj = new JournalClass();
            bool validation;

            validation = addj.addJournal(enterJournalTitle.Text.Trim(), entry.Text.Trim());

            if (validation == true)
            {
                MessageBox.Show("Next Step");

            }
            else
            {
                nameTaken.Foreground.Opacity = 100;
            }

        }

        private void back(object sender, RoutedEventArgs e)
        {
            //TODO
        }
    }
}
