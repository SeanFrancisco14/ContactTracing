using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactTracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            name_Input.Text = information_TextBox.Text;
            age_Input.Text = information_TextBox.Text;
            contact_Input.Text = information_TextBox.Text;
            address_Input.Text = information_TextBox.Text;
        }

        private void name_Input_Click(object sender, EventArgs e)
        {

        }

        private void age_Input_Click(object sender, EventArgs e)
        {

        }

        private void contact_Input_Click(object sender, EventArgs e)
        {

        }

        private void address_Input_Click(object sender, EventArgs e)
        {

        }
    }
}
