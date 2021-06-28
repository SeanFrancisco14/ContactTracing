﻿
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
            this.info_Label = new System.Windows.Forms.Label();
            this.name_Label = new System.Windows.Forms.Label();
            this.age_Label = new System.Windows.Forms.Label();
            this.contact_Label = new System.Windows.Forms.Label();
            this.address_Label = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.OK_button = new System.Windows.Forms.Button();
            this.information_TextBox = new System.Windows.Forms.TextBox();
            this.name_Input = new System.Windows.Forms.Label();
            this.age_Input = new System.Windows.Forms.Label();
            this.contact_Input = new System.Windows.Forms.Label();
            this.address_Input = new System.Windows.Forms.Label();
            this.clear_Button = new System.Windows.Forms.Button();
            this.confirm_Button = new System.Windows.Forms.Button();
            this.incontact_Label = new System.Windows.Forms.Label();
            this.incontact_Input = new System.Windows.Forms.Label();
            this.help_Button = new System.Windows.Forms.Button();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.exit_Button = new System.Windows.Forms.Button();
            this.pnl1.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // info_Label
            // 
            this.info_Label.AutoSize = true;
            this.info_Label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info_Label.Location = new System.Drawing.Point(3, 123);
            this.info_Label.Name = "info_Label";
            this.info_Label.Size = new System.Drawing.Size(206, 32);
            this.info_Label.TabIndex = 0;
            this.info_Label.Text = "Enter Information:";
            // 
            // name_Label
            // 
            this.name_Label.AutoSize = true;
            this.name_Label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_Label.Location = new System.Drawing.Point(9, 162);
            this.name_Label.Name = "name_Label";
            this.name_Label.Size = new System.Drawing.Size(66, 25);
            this.name_Label.TabIndex = 1;
            this.name_Label.Text = "Name:";
            // 
            // age_Label
            // 
            this.age_Label.AutoSize = true;
            this.age_Label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.age_Label.Location = new System.Drawing.Point(9, 188);
            this.age_Label.Name = "age_Label";
            this.age_Label.Size = new System.Drawing.Size(49, 25);
            this.age_Label.TabIndex = 2;
            this.age_Label.Text = "Age:";
            // 
            // contact_Label
            // 
            this.contact_Label.AutoSize = true;
            this.contact_Label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contact_Label.Location = new System.Drawing.Point(8, 215);
            this.contact_Label.Name = "contact_Label";
            this.contact_Label.Size = new System.Drawing.Size(155, 25);
            this.contact_Label.TabIndex = 3;
            this.contact_Label.Text = "Contact Number:";
            // 
            // address_Label
            // 
            this.address_Label.AutoSize = true;
            this.address_Label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address_Label.Location = new System.Drawing.Point(9, 244);
            this.address_Label.Name = "address_Label";
            this.address_Label.Size = new System.Drawing.Size(83, 25);
            this.address_Label.TabIndex = 4;
            this.address_Label.Text = "Address:";
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title_label.Location = new System.Drawing.Point(7, 20);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(308, 45);
            this.title_label.TabIndex = 5;
            this.title_label.Text = "Contact Tracing App";
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
            // information_TextBox
            // 
            this.information_TextBox.Location = new System.Drawing.Point(91, 14);
            this.information_TextBox.Name = "information_TextBox";
            this.information_TextBox.Size = new System.Drawing.Size(239, 25);
            this.information_TextBox.TabIndex = 7;
            // 
            // name_Input
            // 
            this.name_Input.AutoSize = true;
            this.name_Input.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_Input.ForeColor = System.Drawing.Color.Lime;
            this.name_Input.Location = new System.Drawing.Point(193, 163);
            this.name_Input.Name = "name_Input";
            this.name_Input.Size = new System.Drawing.Size(0, 25);
            this.name_Input.TabIndex = 8;
            this.name_Input.Click += new System.EventHandler(this.name_Input_Click);
            // 
            // age_Input
            // 
            this.age_Input.AutoSize = true;
            this.age_Input.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.age_Input.ForeColor = System.Drawing.Color.Lime;
            this.age_Input.Location = new System.Drawing.Point(193, 188);
            this.age_Input.Name = "age_Input";
            this.age_Input.Size = new System.Drawing.Size(0, 25);
            this.age_Input.TabIndex = 9;
            this.age_Input.Click += new System.EventHandler(this.age_Input_Click);
            // 
            // contact_Input
            // 
            this.contact_Input.AutoSize = true;
            this.contact_Input.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contact_Input.ForeColor = System.Drawing.Color.Lime;
            this.contact_Input.Location = new System.Drawing.Point(193, 215);
            this.contact_Input.Name = "contact_Input";
            this.contact_Input.Size = new System.Drawing.Size(0, 25);
            this.contact_Input.TabIndex = 10;
            this.contact_Input.Click += new System.EventHandler(this.contact_Input_Click);
            // 
            // address_Input
            // 
            this.address_Input.AutoSize = true;
            this.address_Input.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address_Input.ForeColor = System.Drawing.Color.Lime;
            this.address_Input.Location = new System.Drawing.Point(193, 244);
            this.address_Input.Name = "address_Input";
            this.address_Input.Size = new System.Drawing.Size(0, 25);
            this.address_Input.TabIndex = 11;
            this.address_Input.Click += new System.EventHandler(this.address_Input_Click);
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
            // incontact_Label
            // 
            this.incontact_Label.AutoSize = true;
            this.incontact_Label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.incontact_Label.Location = new System.Drawing.Point(9, 269);
            this.incontact_Label.Name = "incontact_Label";
            this.incontact_Label.Size = new System.Drawing.Size(468, 25);
            this.incontact_Label.TabIndex = 14;
            this.incontact_Label.Text = "Have you been in contact with other people?: (Yes/No)";
            // 
            // incontact_Input
            // 
            this.incontact_Input.AutoSize = true;
            this.incontact_Input.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.incontact_Input.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.incontact_Input.ForeColor = System.Drawing.Color.Lime;
            this.incontact_Input.Location = new System.Drawing.Point(479, 269);
            this.incontact_Input.Name = "incontact_Input";
            this.incontact_Input.Size = new System.Drawing.Size(0, 25);
            this.incontact_Input.TabIndex = 15;
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
            this.pnl1.Controls.Add(this.title_label);
            this.pnl1.Location = new System.Drawing.Point(81, 12);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(322, 100);
            this.pnl1.TabIndex = 17;
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl2.Controls.Add(this.exit_Button);
            this.pnl2.Controls.Add(this.information_TextBox);
            this.pnl2.Controls.Add(this.OK_button);
            this.pnl2.Controls.Add(this.help_Button);
            this.pnl2.Controls.Add(this.clear_Button);
            this.pnl2.Controls.Add(this.confirm_Button);
            this.pnl2.Location = new System.Drawing.Point(34, 297);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(535, 394);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.incontact_Input);
            this.Controls.Add(this.incontact_Label);
            this.Controls.Add(this.address_Input);
            this.Controls.Add(this.contact_Input);
            this.Controls.Add(this.age_Input);
            this.Controls.Add(this.name_Input);
            this.Controls.Add(this.address_Label);
            this.Controls.Add(this.contact_Label);
            this.Controls.Add(this.age_Label);
            this.Controls.Add(this.name_Label);
            this.Controls.Add(this.info_Label);
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

        private System.Windows.Forms.Label info_Label;
        private System.Windows.Forms.Label name_Label;
        private System.Windows.Forms.Label age_Label;
        private System.Windows.Forms.Label contact_Label;
        private System.Windows.Forms.Label address_Label;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.TextBox information_TextBox;
        private System.Windows.Forms.Label name_Input;
        private System.Windows.Forms.Label age_Input;
        private System.Windows.Forms.Label contact_Input;
        private System.Windows.Forms.Label address_Input;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button confirm_Button;
        private System.Windows.Forms.Label incontact_Label;
        private System.Windows.Forms.Label incontact_Input;
        private System.Windows.Forms.Button help_Button;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Button exit_Button;
    }
}

