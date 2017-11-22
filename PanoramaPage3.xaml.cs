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
    public partial class PanoramaPage3 : PhoneApplicationPage
    {
        public PanoramaPage3 ( )
        {
            InitializeComponent();
        }

        private void listBox1_SelectionChanged ( object sender, SelectionChangedEventArgs e )
        {
            int id = listBox1.SelectedIndex;
            if (id == 0)//1st item
            {
                WebBrowserTask task = new WebBrowserTask();
                task.URL = "http://agakhan.org";
                task.Show();


            }


            if (id == 1) {//2nd item
                PhoneCallTask task = new PhoneCallTask();
                task.PhoneNumber = "0725******";
                task.Show();
            }













        }
    }
}