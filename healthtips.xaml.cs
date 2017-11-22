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
using System.IO;

namespace Charlieproject
{
    public partial class healthtips : PhoneApplicationPage
    {
        public healthtips ( )
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded ( object sender, RoutedEventArgs e )
        {
            //recieve the file name x
            string file = NavigationContext.QueryString["x"];
            var info = Application.GetResourceStream(new Uri(file, UriKind.Relative));
 


            //read
            StreamReader sr = new StreamReader(info.Stream);
            string readinfo = sr.ReadToEnd();
            //set to textblock
            data.Text = readinfo;
            //end 




        }
    }
}