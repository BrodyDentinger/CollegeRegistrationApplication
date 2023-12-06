/*
 Name: Brody Dentinger 
File: AboutDCAppForm.cs
Description: This is the about this application form that will appear over the main application.
Date: Nov. 28, 2023
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSC2100Assignment5BrodyDentinger
{
    public partial class AboutDCAppForm : Form
    {
        public AboutDCAppForm()
        {
            InitializeComponent();
        }

        /*
         About DC application Form exit button.
        Will close this and return to the main form.
         */
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
