/*
 Name: Brody Dentinger 
File: ReadHelpForm.cs
Description: This is the Read Help Form, that will open when the user requires more infromation about the program.
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
    public partial class ReadHelpForm : Form
    {
        public ReadHelpForm()
        {
            InitializeComponent();
        }

        /*
         Exit button from the help form.
        Should close this form instance, returning the user to the main form.
         
         */
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
