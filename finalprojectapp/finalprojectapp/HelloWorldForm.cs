using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace finalprojectapp
{
    public partial class HelloWorldForm : Form
    {
        public HelloWorldForm()
        {
            InitializeComponent();
        }

        private void OrderingLoad(object sender, EventArgs e)
        {
            lblOutput.Text = ""; 
        }

        private void HelloWorldForm_Load(object sender, EventArgs e)
        {
            lblOutput.Text = "Button Clicked"; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
