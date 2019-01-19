using System;
using System.Windows.Forms;
using BaseLib;
using Model;

namespace PresentationLayer
{
    public partial class MainForm : Form
    {
        private readonly IMainController _controller;
        public MainForm(IMainController mainController)
        {
            _controller = mainController;

            InitializeComponent();
        }

        private void AddPensionerButton_Click(object sender, EventArgs e)
        {
            _controller.AddPensioner();
        }
    }
}
