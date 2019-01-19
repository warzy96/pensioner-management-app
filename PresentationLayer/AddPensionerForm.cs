using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseLib;
using Model;

namespace PresentationLayer
{
    public partial class AddPensionerForm : Form
    {
        private readonly PensionerRepository _pensionerRepository;
        public AddPensionerForm(PensionerRepository pensionerRepository)
        {
            _pensionerRepository = pensionerRepository;

            InitializeComponent();
        }

        private void PositiveButton_Click(object sender, EventArgs e)
        {

        }

        private void NegativeButton_Click(object sender, EventArgs e)
        {

        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"^\w+"))
            {
                e.Handled = true;
            }
        }
    }
}
