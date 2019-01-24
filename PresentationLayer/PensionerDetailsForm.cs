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
using NHibernate.Util;

namespace PresentationLayer
{
    public partial class PensionerDetailsForm : Form, IPensionerDetailsForm
    {
        private readonly IPensionerController _controller;
        private readonly Pensioner _pensioner;
        public PensionerDetailsForm(IPensionerController controller, string oib)
        {
            _controller = controller;
            _pensioner = _controller.GetPensioner(oib);

            InitializeComponent();

            if (_pensioner != null)
            {
                UpdateComponents();
            }
        }

        private void UpdateComponents()
        {
            NameTextBox.Text = _pensioner.Name;
            SurnameTextBox.Text = _pensioner.Surname;
            DateOfBirthPicker.Value = _pensioner.DateOfBirth;
            MemberFromDateTimePicker.Value = _pensioner.MembershipStart;
            CityTextBox.Text = _pensioner.CurrentAddress.City;
            TownTextBox.Text = _pensioner.CurrentAddress.Town;
            PostalCodeTextBox.Text = _pensioner.CurrentAddress.PostalCode.ToString();
            StreetTextBox.Text = _pensioner.CurrentAddress.Street;
            OIBTextBox.Text = _pensioner.Oib;
            IdTextBox.Text = _pensioner.Id.ToString();
            PlaceOfBirthTextBox.Text = _pensioner.PlaceOfBirth;
            LowRadioButton.Checked = _pensioner.RequiredPayments.Any(t => t.Type == PaymentType.TypeEnum.MutualAidLow);
            HighRadioButton.Checked = _pensioner.RequiredPayments.Any(t => t.Type == PaymentType.TypeEnum.MutualAidHigh);
        }

        public bool ShowPensionerDetailsForm()
        {
            if (_pensioner != null) return ShowDialog() == DialogResult.OK;
            MessageBox.Show("Umirovljenik ne postoji!");
            return false;
        }
    }
}
