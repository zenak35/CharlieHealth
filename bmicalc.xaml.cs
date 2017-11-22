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
    public partial class bmicalc : PhoneApplicationPage
    {
        public bmicalc ( )
        {
            InitializeComponent();
        }

        private void button1_Click ( object sender, RoutedEventArgs e )
        {
            //COMPUTE BMI
            //Get text from Textboxes using their names
            string w = weight.Text;
            string h = height.Text;

            if (w == "" || h == "")
            {
                MessageBox.Show("Error!! Empty Fields");
            }

            else
            {
                //convert strings to double
                double cweight = Double.Parse(w);
                double cheight = Double.Parse(h);
                double answer = cweight / (cheight * cheight);
                //show answer
                MessageBox.Show("YOUR BMI is: " + answer);
            }
        }
    }
}