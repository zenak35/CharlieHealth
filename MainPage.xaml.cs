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
        public MainPage ( )
        {
            InitializeComponent();
        }

        private void button2_Click ( object sender, RoutedEventArgs e )
            //pass 'sample.txt' to healthtips.xaml
        {
            NavigationService.Navigate(new Uri("/healthtips.xaml?x=sample.txt", UriKind.Relative));
        }

        private void PhoneApplicationPage_Loaded ( object sender, RoutedEventArgs e )
        {

        }

        private void button3_Click ( object sender, RoutedEventArgs e )
        {
            NavigationService.Navigate(new Uri("/services.xaml", UriKind.Relative));
        }

        private void button1_Click ( object sender, RoutedEventArgs e )
        {
            NavigationService.Navigate(new Uri("/bmicalc.xaml", UriKind.Relative));
        }

        private void button4_Click ( object sender, RoutedEventArgs e )
        {
            NavigationService.Navigate(new Uri("/healthtips.xaml?x=food.txt", UriKind.Relative));
        }

        private void button5_Click ( object sender, RoutedEventArgs e )
        {
            NavigationService.Navigate(new Uri("/lancherw.xaml", UriKind.Relative));
        }

        private void button6_Click ( object sender, RoutedEventArgs e )
        {
            NavigationService.Navigate(new Uri("/choosers.xaml", UriKind.Relative));
        }


        private void button11_Click ( object sender, RoutedEventArgs e )
        {
            NavigationService.Navigate(new Uri("/PanoramaPage3.xaml", UriKind.Relative));
        }

        private void ApplicationBarIconButton_Click ( object sender, EventArgs e )
        {

        }

        private void ApplicationBarIconButton_Click_1 ( object sender, EventArgs e )
        {

        }

        private void ApplicationBarIconButton_Click_2 ( object sender, EventArgs e )
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }



    }
}