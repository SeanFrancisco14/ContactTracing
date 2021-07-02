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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void checkContact() 
        {
            if (lbl_HadContactInput.Text.Contains("e"))
            {
                MessageBox.Show("Response recorded" + "\r\n" + "Hello " + lbl_nameInput.Text + "," + " you are : " + lbl_ageInput.Text + " years old. " + "\r\n"
                + "Your contact number is " + lbl_contactNoInput.Text + " and your address is " + lbl_addressInput.Text + "\r\n" +
                  "You have been in contact with others.");
            }
            else if (lbl_HadContactInput.Text.Contains("o"))
            {
                MessageBox.Show("Response recorded" + "\r\n" + "Hello " + lbl_nameInput.Text + "," + " you are : " + lbl_ageInput.Text + " years old. " + "\r\n"
               + "Your contact number is " + lbl_contactNoInput.Text + " and your address is " + lbl_addressInput.Text + "\r\n" +
                 "You have not been in contact with others.");
            }
        }
        public void InfoConfirmation()
        {
            if (lbl_nameInput.Text.Length == 0)
            {
                MessageBox.Show("Insufficient information provided, please fill out all fields!");
            }
            else if (lbl_ageInput.Text.Length == 0)
            {
                MessageBox.Show("Insufficient information provided, please fill out all fields!");
            }
            else if (lbl_contactNoInput.Text.Length == 0)
            {
                MessageBox.Show("Insufficient information provided, please fill out all fields!");
            }
            else if (lbl_addressInput.Text.Length == 0)
            {
                MessageBox.Show("Insufficient information provided, please fill out all fields!");
            }
            else if (lbl_HadContactInput.Text.Length == 0)
            {
                MessageBox.Show("Insufficient information provided, please fill out all fields!");
            }
        }

        public Form1()
        {
            InitializeComponent();
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

        private void OK_button_Click(object sender, EventArgs e)
        {
            if (counter == 1)
            {
                lbl_nameInput.Text = txtBox_Input.Text;
            }
            else if (counter == 2)
            {
                lbl_ageInput.Text = txtBox_Input.Text;
            }
            else if (counter == 3)
            {
                lbl_contactNoInput.Text = txtBox_Input.Text;
            }
            else if (counter == 4)
            {
                lbl_addressInput.Text = txtBox_Input.Text; 
            }
            else if (counter == 5)
            {
                lbl_HadContactInput.Text = txtBox_Input.Text;
            }
            else if (counter == 6)
            {
                lbl_contactCounterInput.Text = txtBox_Input.Text;
            }
            counter++;
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            counter = 1;

            lbl_nameInput.Text = "";
            lbl_ageInput.Text = "";
            lbl_contactNoInput.Text = "";
            lbl_addressInput.Text = "";
            lbl_HadContactInput.Text = "";
            lbl_contactCounterInput.Text = "";
            txtBox_Input.Text = "";

            MessageBox.Show("The Form has now been cleared.");
        }

        private void confirm_Button_Click(object sender, EventArgs e)
        {
            checkContact();
            InfoConfirmation();

            StreamWriter outputFile;
            outputFile = File.AppendText("output.txt");
            outputFile.WriteLine("Name: " + lbl_nameInput.Text);
            outputFile.WriteLine("Age: " + lbl_ageInput.Text);
            outputFile.WriteLine("Contact number: " + lbl_contactNoInput.Text);
            outputFile.WriteLine("Addess:" + lbl_addressInput.Text);
            outputFile.WriteLine("Has been in contact with other people: " + lbl_HadContactInput.Text);
            outputFile.WriteLine("Number of contacts and where: " + lbl_contactCounterInput.Text);
            outputFile.Close();
        }

        private void help_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK - prints typed information unto current field and moves to the next one" + "\r\n"
                + "Clear - deletes all text on fields" + "\r\n" + "Confirm - confirms all information added" + "\r\n");
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The application will now close.");
            Application.Exit();
        }
    }
}
