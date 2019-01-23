using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using BaseLib;
using Model;

namespace PresentationLayer
{
    public partial class MainForm : Form, IMainForm
    {
        private readonly IMainController _controller;
        public MainForm(IMainController mainController)
        {
            _controller = mainController;

            InitializeComponent();
            mainController.UpdatePensionerList(this);
        }

        private void AddPensionerButton_Click(object sender, EventArgs e)
        {
            _controller.AddPensioner();
        }

        public void UpdatePensionerListView(IEnumerable<Pensioner> pensioners)
        {
            foreach (var pensioner in pensioners)
            {
                var listViewItem = new ListViewItem(pensioner.Id.ToString());
                listViewItem.SubItems.Add(pensioner.Name);
                listViewItem.SubItems.Add(pensioner.Surname);
                listViewItem.SubItems.Add(pensioner.CurrentAddress.GetPlaceOfResidence());
                listViewItem.SubItems.Add(pensioner.Oib);

                pensionerList.Items.Add(listViewItem);
            }
        }

        private void pdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ShowCreatePdfForm();
        }
    }
}
