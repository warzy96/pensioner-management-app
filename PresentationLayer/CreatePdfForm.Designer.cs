namespace PresentationLayer
{
    partial class CreatePdfForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OIBCheckBox = new System.Windows.Forms.CheckBox();
            this.IdCheckBox = new System.Windows.Forms.CheckBox();
            this.PlaceOfResidenceCheckBox = new System.Windows.Forms.CheckBox();
            this.CityAndZipCodeCheckBox = new System.Windows.Forms.CheckBox();
            this.MembershipCheckBox = new System.Windows.Forms.CheckBox();
            this.MutualAidCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.OIBCheckBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.IdCheckBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CityAndZipCodeCheckBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PlaceOfResidenceCheckBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.MembershipCheckBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.MutualAidCheckBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.SaveButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.CancelButton, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 439);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SaveButton.Location = new System.Drawing.Point(3, 330);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(394, 106);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Spremi";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(403, 330);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(394, 106);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Odustani";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // OIBCheckBox
            // 
            this.OIBCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OIBCheckBox.AutoSize = true;
            this.OIBCheckBox.Checked = true;
            this.OIBCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OIBCheckBox.Location = new System.Drawing.Point(3, 3);
            this.OIBCheckBox.Name = "OIBCheckBox";
            this.OIBCheckBox.Size = new System.Drawing.Size(394, 103);
            this.OIBCheckBox.TabIndex = 1;
            this.OIBCheckBox.Text = "OIB";
            this.OIBCheckBox.UseVisualStyleBackColor = true;
            // 
            // IdCheckBox
            // 
            this.IdCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdCheckBox.AutoSize = true;
            this.IdCheckBox.Checked = true;
            this.IdCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IdCheckBox.Location = new System.Drawing.Point(403, 3);
            this.IdCheckBox.Name = "IdCheckBox";
            this.IdCheckBox.Size = new System.Drawing.Size(394, 103);
            this.IdCheckBox.TabIndex = 2;
            this.IdCheckBox.Text = "Broj knjižice";
            this.IdCheckBox.UseVisualStyleBackColor = true;
            // 
            // PlaceOfResidenceCheckBox
            // 
            this.PlaceOfResidenceCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlaceOfResidenceCheckBox.AutoSize = true;
            this.PlaceOfResidenceCheckBox.Checked = true;
            this.PlaceOfResidenceCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PlaceOfResidenceCheckBox.Location = new System.Drawing.Point(3, 112);
            this.PlaceOfResidenceCheckBox.Name = "PlaceOfResidenceCheckBox";
            this.PlaceOfResidenceCheckBox.Size = new System.Drawing.Size(394, 103);
            this.PlaceOfResidenceCheckBox.TabIndex = 3;
            this.PlaceOfResidenceCheckBox.Text = "Adresa stanovanja";
            this.PlaceOfResidenceCheckBox.UseVisualStyleBackColor = true;
            // 
            // CityAndZipCodeCheckBox
            // 
            this.CityAndZipCodeCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CityAndZipCodeCheckBox.AutoSize = true;
            this.CityAndZipCodeCheckBox.Location = new System.Drawing.Point(403, 112);
            this.CityAndZipCodeCheckBox.Name = "CityAndZipCodeCheckBox";
            this.CityAndZipCodeCheckBox.Size = new System.Drawing.Size(394, 103);
            this.CityAndZipCodeCheckBox.TabIndex = 4;
            this.CityAndZipCodeCheckBox.Text = "Mjesto i pripadajući poštanski broj";
            this.CityAndZipCodeCheckBox.UseVisualStyleBackColor = true;
            // 
            // MembershipCheckBox
            // 
            this.MembershipCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MembershipCheckBox.AutoSize = true;
            this.MembershipCheckBox.Checked = true;
            this.MembershipCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MembershipCheckBox.Location = new System.Drawing.Point(3, 221);
            this.MembershipCheckBox.Name = "MembershipCheckBox";
            this.MembershipCheckBox.Size = new System.Drawing.Size(394, 103);
            this.MembershipCheckBox.TabIndex = 5;
            this.MembershipCheckBox.Text = "Članarina";
            this.MembershipCheckBox.UseVisualStyleBackColor = true;
            // 
            // MutualAidCheckBox
            // 
            this.MutualAidCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MutualAidCheckBox.AutoSize = true;
            this.MutualAidCheckBox.Location = new System.Drawing.Point(403, 221);
            this.MutualAidCheckBox.Name = "MutualAidCheckBox";
            this.MutualAidCheckBox.Size = new System.Drawing.Size(394, 103);
            this.MutualAidCheckBox.TabIndex = 6;
            this.MutualAidCheckBox.Text = "Uzajamna pomoć";
            this.MutualAidCheckBox.UseVisualStyleBackColor = true;
            // 
            // CreatePdfForm
            // 
            this.AcceptButton = this.SaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(826, 521);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(826, 521);
            this.Name = "CreatePdfForm";
            this.Text = "Stvori Pdf";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.CheckBox OIBCheckBox;
        private System.Windows.Forms.CheckBox IdCheckBox;
        private System.Windows.Forms.CheckBox CityAndZipCodeCheckBox;
        private System.Windows.Forms.CheckBox PlaceOfResidenceCheckBox;
        private System.Windows.Forms.CheckBox MembershipCheckBox;
        private System.Windows.Forms.CheckBox MutualAidCheckBox;
    }
}