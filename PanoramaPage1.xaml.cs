﻿using System;
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
    public partial class PanoramaPage1 : PhoneApplicationPage
    {
        public PanoramaPage1 ( )
        {
            InitializeComponent();
        }

        private void button7_Click ( object sender, RoutedEventArgs e )
        {
            string a = "Eat fruits after every meal"; 
            data.Text = a;
        }
    }
}