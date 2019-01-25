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

        private void pensionerList_MouseClick(object sender, MouseEventArgs e)
        {
            var selectedItem = pensionerList.SelectedItems[0];

            var oibItemText = selectedItem.SubItems[4].Text;

            _controller.ShowPensionerDetailsForm(oibItemText);
        }

        private void AddNewPensionerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.AddPensioner();
        }

        private void GenerateMembershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ShowGenerateMembershipForm();
        }

        private void GenerateMutualAidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ShowGenerateMutualAidForm();
        }
    }
}
