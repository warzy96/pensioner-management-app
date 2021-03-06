﻿namespace PresentationLayer
{
    partial class EditSettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MembershipNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MutualAidLowNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MutualAidHighNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MembershipNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MutualAidLowNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MutualAidHighNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Članarina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Uzajamna pomoć (niža):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Uzajamna pomoć (viša):";
            // 
            // MembershipNumericUpDown
            // 
            this.MembershipNumericUpDown.Location = new System.Drawing.Point(281, 43);
            this.MembershipNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MembershipNumericUpDown.Name = "MembershipNumericUpDown";
            this.MembershipNumericUpDown.Size = new System.Drawing.Size(120, 31);
            this.MembershipNumericUpDown.TabIndex = 6;
            // 
            // MutualAidLowNumericUpDown
            // 
            this.MutualAidLowNumericUpDown.Location = new System.Drawing.Point(281, 143);
            this.MutualAidLowNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MutualAidLowNumericUpDown.Name = "MutualAidLowNumericUpDown";
            this.MutualAidLowNumericUpDown.Size = new System.Drawing.Size(120, 31);
            this.MutualAidLowNumericUpDown.TabIndex = 7;
            // 
            // MutualAidHighNumericUpDown
            // 
            this.MutualAidHighNumericUpDown.Location = new System.Drawing.Point(281, 234);
            this.MutualAidHighNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MutualAidHighNumericUpDown.Name = "MutualAidHighNumericUpDown";
            this.MutualAidHighNumericUpDown.Size = new System.Drawing.Size(120, 31);
            this.MutualAidHighNumericUpDown.TabIndex = 8;
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Location = new System.Drawing.Point(34, 304);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(145, 67);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Spremi";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Location = new System.Drawing.Point(256, 304);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(145, 67);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Odustani";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EditSettingsForm
            // 
            this.AcceptButton = this.SaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 399);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.MutualAidHighNumericUpDown);
            this.Controls.Add(this.MutualAidLowNumericUpDown);
            this.Controls.Add(this.MembershipNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Postavke";
            ((System.ComponentModel.ISupportInitialize)(this.MembershipNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MutualAidLowNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MutualAidHighNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown MembershipNumericUpDown;
        private System.Windows.Forms.NumericUpDown MutualAidLowNumericUpDown;
        private System.Windows.Forms.NumericUpDown MutualAidHighNumericUpDown;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
    }
}