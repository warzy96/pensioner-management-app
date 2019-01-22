using System.Windows.Forms;

namespace PresentationLayer
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddPensionerButton = new System.Windows.Forms.Button();
            this.pensionerList = new System.Windows.Forms.ListView();
            this.IdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SurnameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddressColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OibColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.daToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvozToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.test2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1365, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daToolStripMenuItem,
            this.izvozToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(123, 38);
            this.testToolStripMenuItem.Text = "Datoteka";
            // 
            // test2ToolStripMenuItem
            // 
            this.test2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testicToolStripMenuItem});
            this.test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            this.test2ToolStripMenuItem.Size = new System.Drawing.Size(142, 38);
            this.test2ToolStripMenuItem.Text = "Transakcije";
            // 
            // testicToolStripMenuItem
            // 
            this.testicToolStripMenuItem.Name = "testicToolStripMenuItem";
            this.testicToolStripMenuItem.Size = new System.Drawing.Size(170, 38);
            this.testicToolStripMenuItem.Text = "testic";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pretraži";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(943, 31);
            this.textBox1.TabIndex = 2;
            // 
            // AddPensionerButton
            // 
            this.AddPensionerButton.Location = new System.Drawing.Point(17, 80);
            this.AddPensionerButton.Name = "AddPensionerButton";
            this.AddPensionerButton.Size = new System.Drawing.Size(200, 51);
            this.AddPensionerButton.TabIndex = 3;
            this.AddPensionerButton.Text = "Add Pensioner";
            this.AddPensionerButton.UseVisualStyleBackColor = true;
            this.AddPensionerButton.Click += new System.EventHandler(this.AddPensionerButton_Click);
            // 
            // pensionerList
            // 
            this.pensionerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdColumn,
            this.NameColumn,
            this.SurnameColumn,
            this.AddressColumn,
            this.OibColumn});
            this.pensionerList.Location = new System.Drawing.Point(12, 137);
            this.pensionerList.Name = "pensionerList";
            this.pensionerList.Size = new System.Drawing.Size(1341, 515);
            this.pensionerList.TabIndex = 4;
            this.pensionerList.UseCompatibleStateImageBehavior = false;
            this.pensionerList.View = System.Windows.Forms.View.Details;
            // 
            // IdColumn
            // 
            this.IdColumn.Text = "Broj knjižice";
            this.IdColumn.Width = 101;
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Ime";
            this.NameColumn.Width = 100;
            // 
            // SurnameColumn
            // 
            this.SurnameColumn.Text = "Prezime";
            this.SurnameColumn.Width = 150;
            // 
            // AddressColumn
            // 
            this.AddressColumn.Text = "Mjesto, ulica i broj";
            this.AddressColumn.Width = 200;
            // 
            // OibColumn
            // 
            this.OibColumn.Text = "OIB";
            this.OibColumn.Width = 110;
            // 
            // daToolStripMenuItem
            // 
            this.daToolStripMenuItem.Name = "daToolStripMenuItem";
            this.daToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.daToolStripMenuItem.Text = "Uvoz";
            // 
            // izvozToolStripMenuItem
            // 
            this.izvozToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pdfToolStripMenuItem});
            this.izvozToolStripMenuItem.Name = "izvozToolStripMenuItem";
            this.izvozToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.izvozToolStripMenuItem.Text = "Izvoz";
            // 
            // pdfToolStripMenuItem
            // 
            this.pdfToolStripMenuItem.Name = "pdfToolStripMenuItem";
            this.pdfToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.pdfToolStripMenuItem.Text = "Pdf";
            this.pdfToolStripMenuItem.Click += new System.EventHandler(this.pdfToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 664);
            this.Controls.Add(this.pensionerList);
            this.Controls.Add(this.AddPensionerButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1395, 739);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1395, 739);
            this.Name = "MainForm";
            this.Text = "Udruga umirovljenika";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testicToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddPensionerButton;
        private System.Windows.Forms.ListView pensionerList;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader SurnameColumn;
        private System.Windows.Forms.ColumnHeader AddressColumn;
        private System.Windows.Forms.ColumnHeader OibColumn;
        private System.Windows.Forms.ColumnHeader IdColumn;
        private ToolStripMenuItem daToolStripMenuItem;
        private ToolStripMenuItem izvozToolStripMenuItem;
        private ToolStripMenuItem pdfToolStripMenuItem;
    }
}

