namespace WindowsClient_TeleHealthApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.header = new System.Windows.Forms.Label();
            this.FullNamelbl = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.Emaillbl = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.addresslbl = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.postalcodelbl = new System.Windows.Forms.Label();
            this.Postalcode = new System.Windows.Forms.TextBox();
            this.Datetime = new System.Windows.Forms.DateTimePicker();
            this.datelbl = new System.Windows.Forms.Label();
            this.responselbl = new System.Windows.Forms.Label();
            this.Response = new System.Windows.Forms.RichTextBox();
            this.submitbtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
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
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(178, 49);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(187, 20);
            this.Name.TabIndex = 2;
            this.Name.Validating += new System.ComponentModel.CancelEventHandler(this.Name_Validating);
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
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(178, 84);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(187, 20);
            this.Email.TabIndex = 4;
            this.Email.Validating += new System.ComponentModel.CancelEventHandler(this.Email_Validating);
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
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(178, 121);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(187, 20);
            this.Address.TabIndex = 6;
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
            // Postalcode
            // 
            this.Postalcode.Location = new System.Drawing.Point(178, 160);
            this.Postalcode.Name = "Postalcode";
            this.Postalcode.Size = new System.Drawing.Size(187, 20);
            this.Postalcode.TabIndex = 8;
            // 
            // Datetime
            // 
            this.Datetime.Location = new System.Drawing.Point(178, 202);
            this.Datetime.Name = "Datetime";
            this.Datetime.Size = new System.Drawing.Size(187, 20);
            this.Datetime.TabIndex = 9;
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
            // Response
            // 
            this.Response.Location = new System.Drawing.Point(178, 245);
            this.Response.Name = "Response";
            this.Response.Size = new System.Drawing.Size(187, 101);
            this.Response.TabIndex = 12;
            this.Response.Text = "";
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
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_ClickAsync);
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(415, 294);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(75, 23);
            this.clearbtn.TabIndex = 14;
            this.clearbtn.Text = "CLEAR";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // TeleHealthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 380);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.Response);
            this.Controls.Add(this.responselbl);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.Datetime);
            this.Controls.Add(this.Postalcode);
            this.Controls.Add(this.postalcodelbl);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.addresslbl);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Emaillbl);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.FullNamelbl);
            this.Controls.Add(this.header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Text = "Covid-19 TeleHealth App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label FullNamelbl;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label Emaillbl;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label addresslbl;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label postalcodelbl;
        private System.Windows.Forms.TextBox Postalcode;
        private System.Windows.Forms.DateTimePicker Datetime;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label responselbl;
        private System.Windows.Forms.RichTextBox Response;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.Button clearbtn;
    }
}

