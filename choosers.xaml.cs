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
using Microsoft.Phone.Tasks;
using System.Windows.Media.Imaging;

namespace Charlieproject
{
    public partial class choosers : PhoneApplicationPage
    {
        public choosers ( )
        {
            InitializeComponent();
        }

        private void button1_Click ( object sender, RoutedEventArgs e )
        {
            PhoneNumberChooserTask task = new PhoneNumberChooserTask();
            task.Completed += ( s, evt ) =>
            {
                //Get the selected photo after OK is tapped
                if (evt.Error== null && evt.TaskResult == TaskResult.OK)
                {
                    MessageBox.Show(evt.PhoneNumber);

                }

            };
            task.Show();//show camera task

        }

        private void button1_Click_1 ( object sender, RoutedEventArgs e )
        {
            NavigationService.Navigate(new Uri("/PanoramaPage1.xaml", UriKind.Relative));
        }

    }
}
















