using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Charlieproject
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage ( )
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
        }

        // Handle selection changed on ListBox
        private void MainListBox_SelectionChanged ( object sender, SelectionChangedEventArgs e )
        {
            // If selected index is -1 (no selection) do nothing
            if (MainListBox.SelectedIndex == -1)
                return;

            // Navigate to the new page
            NavigationService.Navigate(new Uri("/DetailsPage.xaml?selectedItem=" + MainListBox.SelectedIndex, UriKind.Relative));

            // Reset selected index to -1 (no selection)
            MainListBox.SelectedIndex = -1;
        }

        // Load data for the ViewModel Items
        private void MainPage_Loaded ( object sender, RoutedEventArgs e )
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }

            string day = System.DateTime.Now.Day.ToString();
            string superscript = "";

            //this parses the date value and inserts the required superscript for the current date...
            if (day.EndsWith("1"))
            {
                superscript = "st";
            }
            else if (day.EndsWith("2"))
            {
                superscript = "nd";
            }
            else if (day.EndsWith("3"))
            {
                superscript = "rd";
            }
            else if (day.EndsWith("4"))
            {
                superscript = "th";
            }
            else if (day.EndsWith("5"))
            {
                superscript = "th";
            }
            else if (day.EndsWith("6"))
            {
                superscript = "th";
            }
            else if (day.EndsWith("7"))
            {
                superscript = "th";
            }
            else if (day.EndsWith("8"))
            {
                superscript = "th";
            }
            else if (day.EndsWith("9"))
            {
                superscript = "th";
            }
            else if (day.EndsWith("0"))
            {
                superscript = "th";
            }

            string date = System.DateTime.Now.DayOfWeek.ToString() + " " + System.DateTime.Now.Day.ToString() + superscript + ",";
            this.HomescreenTitle.Text = date;
            if (MainListBox.Items.Count == 0)
            {
                this.HomescreenStatus.Text = "[you have no notes yet...]";
            }
            else
            {
                this.HomescreenStatus.Text = "hi, your personal notes are #" + MainListBox.Items.Count.ToString();
            }

        }

        #region "HomescreenToolkit"
        /// <summary>
        /// this helps create a new note for the users...
        /// </summary>
        private void ShowCreateNewNoteUI ( )
        {
            NewNote.Visibility = Visibility.Collapsed;
            HeaderContentSeparator.Visibility = Visibility.Collapsed;
            InputContainer.Visibility = Visibility.Visible;
            InputTitle.Visibility = Visibility.Visible;
            InputDescription.Visibility = Visibility.Visible;
            InputBox.Visibility = Visibility.Visible;
            CreateNote.Visibility = Visibility.Visible;
            CancelCreate.Visibility = Visibility.Visible;
        }
        private void HideCreateNewNoteUI ( )
        {
            NewNote.Visibility = Visibility.Visible;
            HeaderContentSeparator.Visibility = Visibility.Visible;
            InputContainer.Visibility = Visibility.Collapsed;
            InputTitle.Visibility = Visibility.Collapsed;
            InputDescription.Visibility = Visibility.Collapsed;
            InputBox.Visibility = Visibility.Collapsed;
            CreateNote.Visibility = Visibility.Collapsed;
            CancelCreate.Visibility = Visibility.Collapsed;
        }
        private void animateContainer ( )
        {
            InputContainer.Visibility = Visibility.Visible;
            InputContainer.Height = 0;
            for (int i = 0; i <= 696; i += 1)
            {
                InputContainer.Height = i;
            }
        }
        #endregion

        private void NewNote_Click ( object sender, RoutedEventArgs e )
        {
            ShowCreateNewNoteUI();
        }

        private void CancelCreate_Click ( object sender, RoutedEventArgs e )
        {
            HideCreateNewNoteUI();
        }

        private void CreateNote_Click ( object sender, RoutedEventArgs e )
        {

        }
    }
}