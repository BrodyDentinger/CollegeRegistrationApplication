/*
 Name: Brody Dentinger 
File: TechSupportForm.cs
Description: This is the tech support form, which will appear over the main form.
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
    public partial class TechSupportForm : Form
    {
        public TechSupportForm()
        {
            InitializeComponent();
        }

        /*
         Tech Support Exit Button.
        Exits this form and returns to the main form.
         */
        private void techSupportExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
