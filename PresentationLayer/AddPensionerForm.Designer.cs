namespace PresentationLayer
{
    partial class AddPensionerForm
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
            this.components = new System.ComponentModel.Container();
            this.PositiveButton = new System.Windows.Forms.Button();
            this.NegativeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.PostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.TownTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MemberFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.PlaceOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.OIBTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.HighRadioButton = new System.Windows.Forms.RadioButton();
            this.LowRadioButton = new System.Windows.Forms.RadioButton();
            this.NoRadioButton = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // PositiveButton
            // 
            this.PositiveButton.Location = new System.Drawing.Point(187, 556);
            this.PositiveButton.Name = "PositiveButton";
            this.PositiveButton.Size = new System.Drawing.Size(149, 60);
            this.PositiveButton.TabIndex = 0;
            this.PositiveButton.Text = "Spremi";
            this.PositiveButton.UseVisualStyleBackColor = true;
            this.PositiveButton.Click += new System.EventHandler(this.PositiveButton_Click);
            // 
            // NegativeButton
            // 
            this.NegativeButton.Location = new System.Drawing.Point(430, 556);
            this.NegativeButton.Name = "NegativeButton";
            this.NegativeButton.Size = new System.Drawing.Size(130, 60);
            this.NegativeButton.TabIndex = 1;
            this.NegativeButton.Text = "Odustani";
            this.NegativeButton.UseVisualStyleBackColor = true;
            this.NegativeButton.Click += new System.EventHandler(this.NegativeButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.MemberFromDateTimePicker);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.PlaceOfBirthTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DateOfBirthPicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.OIBTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SurnameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(852, 403);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osobni podaci";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.CityTextBox);
            this.groupBox2.Controls.Add(this.PostalCodeTextBox);
            this.groupBox2.Controls.Add(this.StreetTextBox);
            this.groupBox2.Controls.Add(this.TownTextBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(7, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(839, 178);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adresa";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(168, 98);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(589, 31);
            this.CityTextBox.TabIndex = 7;
            this.CityTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CityTextBox_Validating);
            // 
            // PostalCodeTextBox
            // 
            this.PostalCodeTextBox.Location = new System.Drawing.Point(168, 135);
            this.PostalCodeTextBox.Name = "PostalCodeTextBox";
            this.PostalCodeTextBox.Size = new System.Drawing.Size(241, 31);
            this.PostalCodeTextBox.TabIndex = 6;
            this.PostalCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PostalCodeTextBox_KeyPress);
            this.PostalCodeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PostalCodeTextBox_Validating);
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Location = new System.Drawing.Point(168, 61);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(589, 31);
            this.StreetTextBox.TabIndex = 5;
            this.StreetTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StreetTextBox_KeyPress);
            this.StreetTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.StreetTextBox_Validating);
            // 
            // TownTextBox
            // 
            this.TownTextBox.Location = new System.Drawing.Point(168, 24);
            this.TownTextBox.Name = "TownTextBox";
            this.TownTextBox.Size = new System.Drawing.Size(589, 31);
            this.TownTextBox.TabIndex = 4;
            this.TownTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TownTextBox_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "Ulica i broj";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Mjesto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Poštanski broj";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Grad";
            // 
            // MemberFromDateTimePicker
            // 
            this.MemberFromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.MemberFromDateTimePicker.Location = new System.Drawing.Point(510, 183);
            this.MemberFromDateTimePicker.Name = "MemberFromDateTimePicker";
            this.MemberFromDateTimePicker.Size = new System.Drawing.Size(260, 31);
            this.MemberFromDateTimePicker.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Član od";
            // 
            // PlaceOfBirthTextBox
            // 
            this.PlaceOfBirthTextBox.Location = new System.Drawing.Point(175, 141);
            this.PlaceOfBirthTextBox.Name = "PlaceOfBirthTextBox";
            this.PlaceOfBirthTextBox.Size = new System.Drawing.Size(595, 31);
            this.PlaceOfBirthTextBox.TabIndex = 9;
            this.PlaceOfBirthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PlaceOfBirthTextBox_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mjesto rođenja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Datum rođenja";
            // 
            // DateOfBirthPicker
            // 
            this.DateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfBirthPicker.Location = new System.Drawing.Point(175, 183);
            this.DateOfBirthPicker.Name = "DateOfBirthPicker";
            this.DateOfBirthPicker.Size = new System.Drawing.Size(241, 31);
            this.DateOfBirthPicker.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "OIB";
            // 
            // OIBTextBox
            // 
            this.OIBTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OIBTextBox.Location = new System.Drawing.Point(175, 104);
            this.OIBTextBox.Name = "OIBTextBox";
            this.OIBTextBox.Size = new System.Drawing.Size(595, 31);
            this.OIBTextBox.TabIndex = 4;
            this.OIBTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OIBTextBox_KeyPress);
            this.OIBTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.OIBTextBox_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ime";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameTextBox.Location = new System.Drawing.Point(175, 67);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(595, 31);
            this.SurnameTextBox.TabIndex = 1;
            this.SurnameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.SurnameTextBox_Validating);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(175, 30);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(595, 31);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NameTextBox_Validating);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.HighRadioButton);
            this.groupBox3.Controls.Add(this.LowRadioButton);
            this.groupBox3.Controls.Add(this.NoRadioButton);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(12, 422);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(770, 68);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Plaćanja";
            // 
            // HighRadioButton
            // 
            this.HighRadioButton.AutoSize = true;
            this.HighRadioButton.Location = new System.Drawing.Point(359, 29);
            this.HighRadioButton.Name = "HighRadioButton";
            this.HighRadioButton.Size = new System.Drawing.Size(85, 29);
            this.HighRadioButton.TabIndex = 3;
            this.HighRadioButton.TabStop = true;
            this.HighRadioButton.Text = "Viša";
            this.HighRadioButton.UseVisualStyleBackColor = true;
            // 
            // LowRadioButton
            // 
            this.LowRadioButton.AutoSize = true;
            this.LowRadioButton.Location = new System.Drawing.Point(267, 29);
            this.LowRadioButton.Name = "LowRadioButton";
            this.LowRadioButton.Size = new System.Drawing.Size(86, 29);
            this.LowRadioButton.TabIndex = 2;
            this.LowRadioButton.TabStop = true;
            this.LowRadioButton.Text = "Niža";
            this.LowRadioButton.UseVisualStyleBackColor = true;
            // 
            // NoRadioButton
            // 
            this.NoRadioButton.AutoSize = true;
            this.NoRadioButton.Location = new System.Drawing.Point(191, 29);
            this.NoRadioButton.Name = "NoRadioButton";
            this.NoRadioButton.Size = new System.Drawing.Size(70, 29);
            this.NoRadioButton.TabIndex = 1;
            this.NoRadioButton.TabStop = true;
            this.NoRadioButton.Text = "Ne";
            this.NoRadioButton.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Uzajamna pomoć";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 499);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 25);
            this.label12.TabIndex = 4;
            this.label12.Text = "Broj knjižice";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(187, 496);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(241, 31);
            this.IdTextBox.TabIndex = 5;
            this.IdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdTextBox_KeyPress);
            this.IdTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.IdTextBox_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // AddPensionerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(876, 650);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NegativeButton);
            this.Controls.Add(this.PositiveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(902, 721);
            this.Name = "AddPensionerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje člana";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PositiveButton;
        private System.Windows.Forms.Button NegativeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OIBTextBox;
        private System.Windows.Forms.TextBox PlaceOfBirthTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateOfBirthPicker;
        private System.Windows.Forms.DateTimePicker MemberFromDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox PostalCodeTextBox;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.TextBox TownTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton HighRadioButton;
        private System.Windows.Forms.RadioButton LowRadioButton;
        private System.Windows.Forms.RadioButton NoRadioButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}