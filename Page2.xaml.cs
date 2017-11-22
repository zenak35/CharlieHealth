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
    public partial class Page2 : PhoneApplicationPage
    {
        public Page2 ( )
        {
            InitializeComponent();
        }

        private void button1_Click ( object sender, RoutedEventArgs e )
        {
              //COMPUTE PAYROLL
            //Get text from Textboxes using their names
            string bs = textBox1.Text;
            string hs = textBox2.Text;
            string ded = textBox3.Text;

            //convert to double
            double cbasic = Double.Parse(bs);
            double chouse = Double.Parse(hs);
            double cdeductions = Double.Parse(ded);
            double answer = (cbasic + chouse) - cdeductions;
            //show answer
            MessageBox.Show("YOUR NETPAY is: " + answer);

            //make decision
            if (answer < 30000)
            {
                MessageBox.Show("YOU GET 5K Bonus");
            }

            else
            {
                MessageBox.Show("YOU GET 10K Bonus");
            }
        }
        }
    }
