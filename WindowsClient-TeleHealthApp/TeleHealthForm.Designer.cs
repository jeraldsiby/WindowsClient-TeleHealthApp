namespace WindowsClient_TeleHealthApp
{
    partial class TeleHealthForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeleHealthForm));
            this.header = new System.Windows.Forms.Label();
            this.FullNamelbl = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.Emaillbl = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.addresslbl = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.postalcodelbl = new System.Windows.Forms.Label();
            this.postalcode = new System.Windows.Forms.TextBox();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.datelbl = new System.Windows.Forms.Label();
            this.responselbl = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.submitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Location = new System.Drawing.Point(66, 18);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(126, 13);
            this.header.TabIndex = 0;
            this.header.Text = "CALLER INFORMATION";
            // 
            // FullNamelbl
            // 
            this.FullNamelbl.AutoSize = true;
            this.FullNamelbl.Location = new System.Drawing.Point(66, 56);
            this.FullNamelbl.Name = "FullNamelbl";
            this.FullNamelbl.Size = new System.Drawing.Size(60, 13);
            this.FullNamelbl.TabIndex = 1;
            this.FullNamelbl.Text = "Full Name: ";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(178, 49);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(187, 20);
            this.name.TabIndex = 2;
            // 
            // Emaillbl
            // 
            this.Emaillbl.AutoSize = true;
            this.Emaillbl.Location = new System.Drawing.Point(66, 91);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(38, 13);
            this.Emaillbl.TabIndex = 3;
            this.Emaillbl.Text = "Email: ";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(178, 84);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(187, 20);
            this.email.TabIndex = 4;
            // 
            // addresslbl
            // 
            this.addresslbl.AutoSize = true;
            this.addresslbl.Location = new System.Drawing.Point(66, 128);
            this.addresslbl.Name = "addresslbl";
            this.addresslbl.Size = new System.Drawing.Size(48, 13);
            this.addresslbl.TabIndex = 5;
            this.addresslbl.Text = "Address:";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(178, 121);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(187, 20);
            this.address.TabIndex = 6;
            // 
            // postalcodelbl
            // 
            this.postalcodelbl.AutoSize = true;
            this.postalcodelbl.Location = new System.Drawing.Point(66, 167);
            this.postalcodelbl.Name = "postalcodelbl";
            this.postalcodelbl.Size = new System.Drawing.Size(67, 13);
            this.postalcodelbl.TabIndex = 7;
            this.postalcodelbl.Text = "Postal Code:";
            // 
            // postalcode
            // 
            this.postalcode.Location = new System.Drawing.Point(178, 160);
            this.postalcode.Name = "postalcode";
            this.postalcode.Size = new System.Drawing.Size(187, 20);
            this.postalcode.TabIndex = 8;
            // 
            // datetime
            // 
            this.datetime.Location = new System.Drawing.Point(178, 202);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(187, 20);
            this.datetime.TabIndex = 9;
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Location = new System.Drawing.Point(66, 209);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(33, 13);
            this.datelbl.TabIndex = 10;
            this.datelbl.Text = "Date:";
            // 
            // responselbl
            // 
            this.responselbl.AutoSize = true;
            this.responselbl.Location = new System.Drawing.Point(66, 248);
            this.responselbl.Name = "responselbl";
            this.responselbl.Size = new System.Drawing.Size(87, 13);
            this.responselbl.TabIndex = 11;
            this.responselbl.Text = "Caller Response:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(178, 245);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(187, 101);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // submitbtn
            // 
            this.submitbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.submitbtn.Location = new System.Drawing.Point(415, 323);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(75, 23);
            this.submitbtn.TabIndex = 13;
            this.submitbtn.Text = "SUBMIT";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 380);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.responselbl);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.postalcode);
            this.Controls.Add(this.postalcodelbl);
            this.Controls.Add(this.address);
            this.Controls.Add(this.addresslbl);
            this.Controls.Add(this.email);
            this.Controls.Add(this.Emaillbl);
            this.Controls.Add(this.name);
            this.Controls.Add(this.FullNamelbl);
            this.Controls.Add(this.header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "Form1";
            this.Text = "Covid-19 TeleHealth App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label FullNamelbl;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label Emaillbl;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label addresslbl;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label postalcodelbl;
        private System.Windows.Forms.TextBox postalcode;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label responselbl;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button submitbtn;
    }
}

