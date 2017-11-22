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

namespace Charlieproject
{
    public partial class launcherw : PhoneApplicationPage
    {
        public launcherw ( )
        {
            InitializeComponent();
        }

        private void button3_Click ( object sender, RoutedEventArgs e )
        {
            MediaPlayerLauncher task = new MediaPlayerLauncher();
            task.Media = new Uri("Kalimba.mp3", UriKind.Relative);
            task.Location = MediaLocationType.Install;
            task.Show();

        }

        private void button1_Click ( object sender, RoutedEventArgs e )
        {
            6+//Bing search
            SearchTask task = new SearchTask();
            task.SearchQuery = "health tips";
            task.Show();
        }
        
        private void button2_Click ( object sender, RoutedEventArgs e )
        {
            MediaPlayerLauncher task = new MediaPlayerLauncher();
            task.Media = new Uri("http://localhost/audio/june.mp4", UriKind.Relative);
            task.Location = MediaLocationType.Install;
            task.Show();

        }

        private void button4_Click ( object sender, RoutedEventArgs e )
        {
            NavigationService.Navigate(new Uri("/choosers.xaml", UriKind.Relative));
        }
    }
}