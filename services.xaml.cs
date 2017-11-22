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
    public partial class services : PhoneApplicationPage
    {
        public services ( )
        {
            InitializeComponent();
        }

        private void button1_Click ( object sender, RoutedEventArgs e )
        {

            string type = "";
            string services = "";
            if (inpatient.IsChecked == true)
            {
                type = " In Patient";
            }

            if (outpatient.IsChecked == true)
            {
                type = "Out Patient";
            }
            //for check boxes
            if (Ambulance.IsChecked == true)
            {
                services = "Ambulance Services";
            }//2nd check box
            if (Laboratory.IsChecked == true)
            {
                services += "Lab Services";
            }//3rd check box
            if (Clinic.IsChecked == true)
            {
                services += "clinical Services";
            }
            MessageBox.Show("You Picked:" + type + " AND " + services);






        }

        private void checkBox1_Checked ( object sender, RoutedEventArgs e )
        {

        }

        private void button2_Click ( object sender, RoutedEventArgs e )
        {
            //MAKE PHONE CALL
            PhoneCallTask task = new PhoneCallTask();
            task.PhoneNumber = "0794787238";
            task.DisplayName = "mhealth Consultant";
            task.Show();




        }

        private void button3_Click ( object sender, RoutedEventArgs e )
        {
            //MAKE PHONE CALL
            SmsComposeTask task = new SmsComposeTask();
            task.To = "0722811292";
            task.Body = "Hello !! mHealth is a Good App !";
            task.Show();
        }

        private void button4_Click ( object sender, RoutedEventArgs e )
        {
            WebBrowserTask task = new WebBrowserTask();
            task.URL = "http://nation.co.ke";
            task.Show();

        }
    }
}