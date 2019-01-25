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
    public partial class GenerateTransactionForm : Form, IGenerateTransactionForm
    {
        private readonly ITransactionController _controller;
        public GenerateTransactionForm(ITransactionController controller)
        {
            _controller = controller;

            InitializeComponent();

            YearPicker.Format = DateTimePickerFormat.Custom;
            YearPicker.CustomFormat = "yyyy.";
            //YearPicker.ShowUpDown = true;
        }

        public bool ShowGenerateTransactionForm(string formTitle)
        {
            Text = formTitle;
            return ShowDialog() == DialogResult.OK;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            PaymentType.TypeEnumNames.TryGetValue(PaymentType.TypeEnum.MutualAid, out var mutualAidTitle);
            PaymentType.TypeEnumNames.TryGetValue(PaymentType.TypeEnum.Membership, out var membershipTitle);

            if (Text.Equals(membershipTitle))
            {
                _controller.GenerateMembershipTransactions(YearPicker.Value);
            }
            else if(Text.Equals(mutualAidTitle))
            {
                _controller.GenerateMutualAidTransactions(YearPicker.Value);
            }

            Close();
        }
    }
}
