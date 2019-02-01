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
using NHibernate.Cfg;

namespace PresentationLayer
{
    public partial class EditSettingsForm : Form, IEditSettingsForm
    {
        public EditSettingsForm()
        {
            InitializeComponent();

            MembershipNumericUpDown.Value = (decimal) Model.Properties.Settings.Default.MembershipFee;
            MutualAidLowNumericUpDown.Value = (decimal) Model.Properties.Settings.Default.MutualAidLowFee;
            MutualAidHighNumericUpDown.Value = (decimal) Model.Properties.Settings.Default.MutualAidHighFee;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Model.Properties.Settings.Default.MembershipFee = (double) MembershipNumericUpDown.Value;
            Model.Properties.Settings.Default.MutualAidLowFee = (double)MutualAidLowNumericUpDown.Value;
            Model.Properties.Settings.Default.MutualAidHighFee = (double)MutualAidHighNumericUpDown.Value;

            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ShowForm()
        {
            ShowDialog();
        }
    }
}
