
namespace ContactTracing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.lbl_ContactNo = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.OK_button = new System.Windows.Forms.Button();
            this.txtBox_Input = new System.Windows.Forms.TextBox();
            this.lbl_nameInput = new System.Windows.Forms.Label();
            this.lbl_ageInput = new System.Windows.Forms.Label();
            this.lbl_contactNoInput = new System.Windows.Forms.Label();
            this.lbl_addressInput = new System.Windows.Forms.Label();
            this.clear_Button = new System.Windows.Forms.Button();
            this.confirm_Button = new System.Windows.Forms.Button();
            this.lbl_HadContact = new System.Windows.Forms.Label();
            this.lbl_HadContactInput = new System.Windows.Forms.Label();
            this.help_Button = new System.Windows.Forms.Button();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.exit_Button = new System.Windows.Forms.Button();
            this.lbl_contactCounter = new System.Windows.Forms.Label();
            this.lbl_contactCounterInput = new System.Windows.Forms.Label();
            this.pnl1.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl2.Location = new System.Drawing.Point(12, 88);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(181, 30);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = "Enter Information:";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Name.Location = new System.Drawing.Point(18, 127);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(55, 21);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name:";
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Age.Location = new System.Drawing.Point(18, 153);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(40, 21);
            this.lbl_Age.TabIndex = 2;
            this.lbl_Age.Text = "Age:";
            // 
            // lbl_ContactNo
            // 
            this.lbl_ContactNo.AutoSize = true;
            this.lbl_ContactNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ContactNo.Location = new System.Drawing.Point(17, 180);
            this.lbl_ContactNo.Name = "lbl_ContactNo";
            this.lbl_ContactNo.Size = new System.Drawing.Size(128, 21);
            this.lbl_ContactNo.TabIndex = 3;
            this.lbl_ContactNo.Text = "Contact Number:";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Address.Location = new System.Drawing.Point(18, 209);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(69, 21);
            this.lbl_Address.TabIndex = 4;
            this.lbl_Address.Text = "Address:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(3, 13);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(308, 45);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Contact Tracing App";
            // 
            // OK_button
            // 
            this.OK_button.Location = new System.Drawing.Point(10, 45);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(75, 23);
            this.OK_button.TabIndex = 6;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // txtBox_Input
            // 
            this.txtBox_Input.Location = new System.Drawing.Point(91, 14);
            this.txtBox_Input.Name = "txtBox_Input";
            this.txtBox_Input.Size = new System.Drawing.Size(239, 25);
            this.txtBox_Input.TabIndex = 7;
            // 
            // lbl_nameInput
            // 
            this.lbl_nameInput.AutoSize = true;
            this.lbl_nameInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nameInput.ForeColor = System.Drawing.Color.Lime;
            this.lbl_nameInput.Location = new System.Drawing.Point(458, 128);
            this.lbl_nameInput.Name = "lbl_nameInput";
            this.lbl_nameInput.Size = new System.Drawing.Size(0, 25);
            this.lbl_nameInput.TabIndex = 8;
            this.lbl_nameInput.Click += new System.EventHandler(this.name_Input_Click);
            // 
            // lbl_ageInput
            // 
            this.lbl_ageInput.AutoSize = true;
            this.lbl_ageInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ageInput.ForeColor = System.Drawing.Color.Lime;
            this.lbl_ageInput.Location = new System.Drawing.Point(458, 153);
            this.lbl_ageInput.Name = "lbl_ageInput";
            this.lbl_ageInput.Size = new System.Drawing.Size(0, 25);
            this.lbl_ageInput.TabIndex = 9;
            this.lbl_ageInput.Click += new System.EventHandler(this.age_Input_Click);
            // 
            // lbl_contactNoInput
            // 
            this.lbl_contactNoInput.AutoSize = true;
            this.lbl_contactNoInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_contactNoInput.ForeColor = System.Drawing.Color.Lime;
            this.lbl_contactNoInput.Location = new System.Drawing.Point(458, 180);
            this.lbl_contactNoInput.Name = "lbl_contactNoInput";
            this.lbl_contactNoInput.Size = new System.Drawing.Size(0, 25);
            this.lbl_contactNoInput.TabIndex = 10;
            this.lbl_contactNoInput.Click += new System.EventHandler(this.contact_Input_Click);
            // 
            // lbl_addressInput
            // 
            this.lbl_addressInput.AutoSize = true;
            this.lbl_addressInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_addressInput.ForeColor = System.Drawing.Color.Lime;
            this.lbl_addressInput.Location = new System.Drawing.Point(458, 209);
            this.lbl_addressInput.Name = "lbl_addressInput";
            this.lbl_addressInput.Size = new System.Drawing.Size(0, 25);
            this.lbl_addressInput.TabIndex = 11;
            this.lbl_addressInput.Click += new System.EventHandler(this.address_Input_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Location = new System.Drawing.Point(91, 45);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(75, 23);
            this.clear_Button.TabIndex = 12;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // confirm_Button
            // 
            this.confirm_Button.Location = new System.Drawing.Point(174, 45);
            this.confirm_Button.Name = "confirm_Button";
            this.confirm_Button.Size = new System.Drawing.Size(75, 23);
            this.confirm_Button.TabIndex = 13;
            this.confirm_Button.Text = "Confirm";
            this.confirm_Button.UseVisualStyleBackColor = true;
            this.confirm_Button.Click += new System.EventHandler(this.confirm_Button_Click);
            // 
            // lbl_HadContact
            // 
            this.lbl_HadContact.AutoSize = true;
            this.lbl_HadContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_HadContact.Location = new System.Drawing.Point(18, 234);
            this.lbl_HadContact.Name = "lbl_HadContact";
            this.lbl_HadContact.Size = new System.Drawing.Size(384, 21);
            this.lbl_HadContact.TabIndex = 14;
            this.lbl_HadContact.Text = "Have you been in contact with other people?: (Yes/No)";
            // 
            // lbl_HadContactInput
            // 
            this.lbl_HadContactInput.AutoSize = true;
            this.lbl_HadContactInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_HadContactInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_HadContactInput.ForeColor = System.Drawing.Color.Lime;
            this.lbl_HadContactInput.Location = new System.Drawing.Point(458, 234);
            this.lbl_HadContactInput.Name = "lbl_HadContactInput";
            this.lbl_HadContactInput.Size = new System.Drawing.Size(0, 25);
            this.lbl_HadContactInput.TabIndex = 15;
            // 
            // help_Button
            // 
            this.help_Button.Location = new System.Drawing.Point(255, 45);
            this.help_Button.Name = "help_Button";
            this.help_Button.Size = new System.Drawing.Size(75, 23);
            this.help_Button.TabIndex = 16;
            this.help_Button.Text = "Help";
            this.help_Button.UseVisualStyleBackColor = true;
            this.help_Button.Click += new System.EventHandler(this.help_Button_Click);
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl1.Controls.Add(this.lbl1);
            this.pnl1.Location = new System.Drawing.Point(177, 12);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(318, 73);
            this.pnl1.TabIndex = 17;
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl2.Controls.Add(this.exit_Button);
            this.pnl2.Controls.Add(this.txtBox_Input);
            this.pnl2.Controls.Add(this.OK_button);
            this.pnl2.Controls.Add(this.help_Button);
            this.pnl2.Controls.Add(this.clear_Button);
            this.pnl2.Controls.Add(this.confirm_Button);
            this.pnl2.Location = new System.Drawing.Point(117, 299);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(424, 83);
            this.pnl2.TabIndex = 18;
            // 
            // exit_Button
            // 
            this.exit_Button.Location = new System.Drawing.Point(336, 45);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(75, 23);
            this.exit_Button.TabIndex = 19;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // lbl_contactCounter
            // 
            this.lbl_contactCounter.AutoSize = true;
            this.lbl_contactCounter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_contactCounter.Location = new System.Drawing.Point(18, 265);
            this.lbl_contactCounter.Name = "lbl_contactCounter";
            this.lbl_contactCounter.Size = new System.Drawing.Size(346, 21);
            this.lbl_contactCounter.TabIndex = 19;
            this.lbl_contactCounter.Text = "If yes, how many and where? If no, leave it blank.";
            // 
            // lbl_contactCounterInput
            // 
            this.lbl_contactCounterInput.AutoSize = true;
            this.lbl_contactCounterInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_contactCounterInput.ForeColor = System.Drawing.Color.Lime;
            this.lbl_contactCounterInput.Location = new System.Drawing.Point(458, 265);
            this.lbl_contactCounterInput.Name = "lbl_contactCounterInput";
            this.lbl_contactCounterInput.Size = new System.Drawing.Size(0, 25);
            this.lbl_contactCounterInput.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(690, 394);
            this.Controls.Add(this.lbl_contactCounterInput);
            this.Controls.Add(this.lbl_contactCounter);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.lbl_HadContactInput);
            this.Controls.Add(this.lbl_HadContact);
            this.Controls.Add(this.lbl_addressInput);
            this.Controls.Add(this.lbl_contactNoInput);
            this.Controls.Add(this.lbl_ageInput);
            this.Controls.Add(this.lbl_nameInput);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.lbl_ContactNo);
            this.Controls.Add(this.lbl_Age);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Contact Tracing App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.Label lbl_ContactNo;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.TextBox txtBox_Input;
        private System.Windows.Forms.Label lbl_nameInput;
        private System.Windows.Forms.Label lbl_ageInput;
        private System.Windows.Forms.Label lbl_contactNoInput;
        private System.Windows.Forms.Label lbl_addressInput;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button confirm_Button;
        private System.Windows.Forms.Label lbl_HadContact;
        private System.Windows.Forms.Label lbl_HadContactInput;
        private System.Windows.Forms.Button help_Button;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Button exit_Button;
        private System.Windows.Forms.Label lbl_contactCounter;
        private System.Windows.Forms.Label lbl_contactCounterInput;
    }
}

