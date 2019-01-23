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
    public partial class CreatePdfForm : Form, ICreatePdfForm
    {
        private readonly IFileController _fileController;
        public CreatePdfForm(IFileController controller)
        {
            _fileController = controller;

            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var attributeList = new List<Enums.OutputAttributes>();
            if (OIBCheckBox.Checked)
            {
                attributeList.Add(Enums.OutputAttributes.OIB);
            }

            if (IdCheckBox.Checked)
            {
                attributeList.Add(Enums.OutputAttributes.Id);
            }

            if (PlaceOfResidenceCheckBox.Checked)
            {
                attributeList.Add(Enums.OutputAttributes.PlaceOfResidence);
            }

            if (CityAndZipCodeCheckBox.Checked)
            {
                attributeList.Add(Enums.OutputAttributes.CityAndZipCode);
            }

            if (MembershipCheckBox.Checked)
            {
                attributeList.Add(Enums.OutputAttributes.Membership);
            }

            if (MutualAidCheckBox.Checked)
            {
                attributeList.Add(Enums.OutputAttributes.MutualAid);
            }

            _fileController.CreateFile(attributeList);
        }

        public bool ShowCreatePdfForm()
        {
            return ShowDialog() == DialogResult.OK;
        }
    }
}
