
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
            this.SuspendLayout();
            // 
            // info_Label
            // 
            this.info_Label.AutoSize = true;
            this.info_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info_Label.Location = new System.Drawing.Point(6, 73);
            this.info_Label.Name = "info_Label";
            this.info_Label.Size = new System.Drawing.Size(181, 30);
            this.info_Label.TabIndex = 0;
            this.info_Label.Text = "Enter Information:";
            // 
            // name_Label
            // 
            this.name_Label.AutoSize = true;
            this.name_Label.Location = new System.Drawing.Point(12, 112);
            this.name_Label.Name = "name_Label";
            this.name_Label.Size = new System.Drawing.Size(46, 17);
            this.name_Label.TabIndex = 1;
            this.name_Label.Text = "Name:";
            // 
            // age_Label
            // 
            this.age_Label.AutoSize = true;
            this.age_Label.Location = new System.Drawing.Point(12, 138);
            this.age_Label.Name = "age_Label";
            this.age_Label.Size = new System.Drawing.Size(34, 17);
            this.age_Label.TabIndex = 2;
            this.age_Label.Text = "Age:";
            // 
            // contact_Label
            // 
            this.contact_Label.AutoSize = true;
            this.contact_Label.Location = new System.Drawing.Point(11, 165);
            this.contact_Label.Name = "contact_Label";
            this.contact_Label.Size = new System.Drawing.Size(107, 17);
            this.contact_Label.TabIndex = 3;
            this.contact_Label.Text = "Contact Number:";
            // 
            // address_Label
            // 
            this.address_Label.AutoSize = true;
            this.address_Label.Location = new System.Drawing.Point(12, 194);
            this.address_Label.Name = "address_Label";
            this.address_Label.Size = new System.Drawing.Size(59, 17);
            this.address_Label.TabIndex = 4;
            this.address_Label.Text = "Address:";
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title_label.Location = new System.Drawing.Point(230, 9);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(308, 45);
            this.title_label.TabIndex = 5;
            this.title_label.Text = "Contact Tracing App";
            // 
            // OK_button
            // 
            this.OK_button.Location = new System.Drawing.Point(12, 374);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(75, 23);
            this.OK_button.TabIndex = 6;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            // 
            // information_TextBox
            // 
            this.information_TextBox.Location = new System.Drawing.Point(11, 343);
            this.information_TextBox.Name = "information_TextBox";
            this.information_TextBox.Size = new System.Drawing.Size(100, 25);
            this.information_TextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.information_TextBox);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.address_Label);
            this.Controls.Add(this.contact_Label);
            this.Controls.Add(this.age_Label);
            this.Controls.Add(this.name_Label);
            this.Controls.Add(this.info_Label);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Contact Tracing App";
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
    }
}

