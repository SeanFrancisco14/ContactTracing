using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactTracing
{
    public partial class Form1 : Form
    {
        byte counter = 1;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void OK_button_Click(object sender, EventArgs e)
        {
            if (counter == 1)
            {
                name_Input.Text = information_TextBox.Text;
            }
            else if (counter == 2)
            {
                age_Input.Text = information_TextBox.Text;
            }
            else if (counter == 3)
            {
                contact_Input.Text = information_TextBox.Text;
            }
            else if (counter == 4)
            { 
                address_Input.Text = information_TextBox.Text; 
            }
            else
            {
                incontact_Input.Text = information_TextBox.Text;
            }
           counter++;
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

        private void clear_Button_Click(object sender, EventArgs e)
        {
            counter = 1;

            name_Input.Text = "";
            age_Input.Text = "" ;
            contact_Input.Text = "";
            address_Input.Text = "";
            incontact_Input.Text = "";
        }

        public void infoConfirmation()
        {
            if (name_Input.Text.Contains(""))
            {
                MessageBox.Show("Insufficient information provided, please fill out all fields!");
            }
            else if (age_Input.Text.Contains(""))
            {
                MessageBox.Show("Insufficient information provided, please fill out all fields!");
            }
            else if (contact_Input.Text.Contains(""))
            {
                MessageBox.Show("Insufficient information provided, please fill out all fields!");
            }
            else if (address_Input.Text.Contains(""))
            {
                MessageBox.Show("Insufficient information provided, please fill out all fields!");
            }
            else if (incontact_Input.Text.Contains(""))
            {
                MessageBox.Show("Insufficient information provided, please fill out all fields!");
            }
        }

        private void confirm_Button_Click(object sender, EventArgs e)
        {
            infoConfirmation();

            if (incontact_Input.Text.Contains("e"))
                {
                    MessageBox.Show("Hello " + name_Input.Text + "," + " you are : " + age_Input.Text + " years old. " + "\r\n"
                    + "Your contact number is " + contact_Input.Text + " and your address is " + address_Input.Text + "\r\n" +
                      "You have been in contact with others.");
                }
                else if (incontact_Input.Text.Contains("o"))
                {
                    MessageBox.Show("Hello " + name_Input.Text + "," + " you are : " + age_Input.Text + " years old. " + "\r\n"
                   + "Your contact number is " + contact_Input.Text + " and your address is " + address_Input.Text + "\r\n" +
                     "You have not been in contact with others.");
                }
            
            StreamWriter outputFile;
            outputFile = File.AppendText("output.txt");
            outputFile.WriteLine("Name: " + name_Input.Text);
            outputFile.WriteLine("Age: " + age_Input.Text);
            outputFile.WriteLine("Contact number: " + contact_Input.Text);
            outputFile.WriteLine("Addess:" + address_Input.Text);
            outputFile.WriteLine("Has been in contact with other people:" + incontact_Input.Text);
            outputFile.Close();
        }
    }
}
