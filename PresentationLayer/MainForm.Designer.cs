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
            this.ImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GenerateMembershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pensionerList = new System.Windows.Forms.ListView();
            this.IdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SurnameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddressColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OibColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.članoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewPensionerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchButton = new System.Windows.Forms.Button();
            this.GenerateMutualAidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.test2ToolStripMenuItem,
            this.članoviToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1365, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportToolStripMenuItem,
            this.ExportToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(123, 38);
            this.testToolStripMenuItem.Text = "Datoteka";
            // 
            // ImportToolStripMenuItem
            // 
            this.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem";
            this.ImportToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.ImportToolStripMenuItem.Text = "Uvoz";
            // 
            // ExportToolStripMenuItem
            // 
            this.ExportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PdfToolStripMenuItem});
            this.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem";
            this.ExportToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.ExportToolStripMenuItem.Text = "Izvoz";
            // 
            // PdfToolStripMenuItem
            // 
            this.PdfToolStripMenuItem.Name = "PdfToolStripMenuItem";
            this.PdfToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.PdfToolStripMenuItem.Text = "Pdf";
            this.PdfToolStripMenuItem.Click += new System.EventHandler(this.pdfToolStripMenuItem_Click);
            // 
            // test2ToolStripMenuItem
            // 
            this.test2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenerateMembershipToolStripMenuItem,
            this.GenerateMutualAidToolStripMenuItem});
            this.test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            this.test2ToolStripMenuItem.Size = new System.Drawing.Size(142, 38);
            this.test2ToolStripMenuItem.Text = "Transakcije";
            // 
            // GenerateMembershipToolStripMenuItem
            // 
            this.GenerateMembershipToolStripMenuItem.Name = "GenerateMembershipToolStripMenuItem";
            this.GenerateMembershipToolStripMenuItem.Size = new System.Drawing.Size(402, 38);
            this.GenerateMembershipToolStripMenuItem.Text = "Generiraj članarinu";
            this.GenerateMembershipToolStripMenuItem.Click += new System.EventHandler(this.GenerateMembershipToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1035, 31);
            this.textBox1.TabIndex = 2;
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
            this.pensionerList.MultiSelect = false;
            this.pensionerList.Name = "pensionerList";
            this.pensionerList.Size = new System.Drawing.Size(1341, 515);
            this.pensionerList.TabIndex = 4;
            this.pensionerList.UseCompatibleStateImageBehavior = false;
            this.pensionerList.View = System.Windows.Forms.View.Details;
            this.pensionerList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pensionerList_MouseClick);
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
            // članoviToolStripMenuItem
            // 
            this.članoviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewPensionerToolStripMenuItem});
            this.članoviToolStripMenuItem.Name = "članoviToolStripMenuItem";
            this.članoviToolStripMenuItem.Size = new System.Drawing.Size(106, 38);
            this.članoviToolStripMenuItem.Text = "Članovi";
            // 
            // AddNewPensionerToolStripMenuItem
            // 
            this.AddNewPensionerToolStripMenuItem.Name = "AddNewPensionerToolStripMenuItem";
            this.AddNewPensionerToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.AddNewPensionerToolStripMenuItem.Text = "Dodaj novog člana";
            this.AddNewPensionerToolStripMenuItem.Click += new System.EventHandler(this.AddNewPensionerToolStripMenuItem_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(1070, 48);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(283, 44);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Pretraži";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // GenerateMutualAidToolStripMenuItem
            // 
            this.GenerateMutualAidToolStripMenuItem.Name = "GenerateMutualAidToolStripMenuItem";
            this.GenerateMutualAidToolStripMenuItem.Size = new System.Drawing.Size(402, 38);
            this.GenerateMutualAidToolStripMenuItem.Text = "Generiraj uzajamnu pomoć";
            this.GenerateMutualAidToolStripMenuItem.Click += new System.EventHandler(this.GenerateMutualAidToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 664);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.pensionerList);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.ToolStripMenuItem GenerateMembershipToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView pensionerList;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader SurnameColumn;
        private System.Windows.Forms.ColumnHeader AddressColumn;
        private System.Windows.Forms.ColumnHeader OibColumn;
        private System.Windows.Forms.ColumnHeader IdColumn;
        private ToolStripMenuItem ImportToolStripMenuItem;
        private ToolStripMenuItem ExportToolStripMenuItem;
        private ToolStripMenuItem PdfToolStripMenuItem;
        private ToolStripMenuItem članoviToolStripMenuItem;
        private ToolStripMenuItem AddNewPensionerToolStripMenuItem;
        private Button SearchButton;
        private ToolStripMenuItem GenerateMutualAidToolStripMenuItem;
    }
}

