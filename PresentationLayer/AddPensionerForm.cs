using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseLib;
using DataAccessLayer;
using Model;
using Model.Repositories;
using NHibernate.Cfg;

namespace PresentationLayer
{
    public partial class AddPensionerForm : Form, IAddPensionerForm
    {
        private readonly IPensionerRepository _pensionerRepository;
        public AddPensionerForm(IPensionerRepository pensionerRepository)
        {
            _pensionerRepository = pensionerRepository;

            InitializeComponent();
        }

        private void PositiveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren()) return;
            var id = int.Parse(IdTextBox.Text);
            var name = NameTextBox.Text.Trim();
            var surname = SurnameTextBox.Text.Trim();
            var dateOfBirth = DateOfBirthPicker.Value;
            var membershipStart = MemberFromDateTimePicker.Value;
            var oib = OIBTextBox.Text.Trim();
            var placeOfBirth = PlaceOfBirthTextBox.Text.Trim();
            var city = CityTextBox.Text.Trim();
            var town = TownTextBox.Text.Trim();
            var street = StreetTextBox.Text.Trim();
            var postalCode = int.Parse(PostalCodeTextBox.Text);

            PaymentType requiredPayment = null;
            if (HighRadioButton.Checked)
            {
                requiredPayment = new PaymentType(PaymentType.TypeEnum.MutualAidHigh, Model.Properties.Settings.Default.MutualAidHighFee);
            }
            else if(LowRadioButton.Checked)
            {
                requiredPayment = new PaymentType(PaymentType.TypeEnum.MutualAidHigh, Model.Properties.Settings.Default.MutualAidLowFee);
            }

            if (_pensionerRepository.GetPensioner(id) != null)
            {
                MessageBox.Show("Umirovljenik s unesenim brojem knjižice već postoji!");
                return;
            }
            _pensionerRepository.AddPensioner(id, oib, name, surname, dateOfBirth, membershipStart, placeOfBirth, city, town, street, postalCode, requiredPayment);
            Close();
        }

        private void NegativeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NameTextBox_Validating(object sender, CancelEventArgs e)
        {
            HandleValidation(NameTextBox, "Polje ne smije biti prazno! Dozvoljena su samo slova!", e);
        }

        private void SurnameTextBox_Validating(object sender, CancelEventArgs e)
        {
            HandleValidation(SurnameTextBox, "Polje ne smije biti prazno! Dozvoljena su samo slova!", e);
        }

        private void PlaceOfBirthTextBox_Validating(object sender, CancelEventArgs e)
        {
            HandleValidation(PlaceOfBirthTextBox, "Polje ne smije biti prazno! Dozvoljena su samo slova!", e);
        }

        private void TownTextBox_Validating(object sender, CancelEventArgs e)
        {
            HandleValidation(TownTextBox, "Polje ne smije biti prazno! Dozvoljena su samo slova!", e);
        }

        private void CityTextBox_Validating(object sender, CancelEventArgs e)
        {
            HandleValidation(CityTextBox, "Polje ne smije biti prazno! Dozvoljena su samo slova!", e);
        }

        private void HandleValidation(Control textBox, string message, CancelEventArgs e)
        {
            textBox.Text = textBox.Text.Trim();
            if (textBox.Text.Any(char.IsNumber) || string.IsNullOrEmpty(textBox.Text))
            {
                errorProvider.SetError(textBox, message);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textBox, null);
            }
        }

        private void PostalCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar == (char) Keys.Back || char.IsNumber(e.KeyChar));
        }

        private void PostalCodeTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (PostalCodeTextBox.Text.Length != 5)
            {
                errorProvider.SetError(PostalCodeTextBox, "Nije važeći poštanski broj!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(PostalCodeTextBox, null);
            }
        }

        private void StreetTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.Tab || char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar));
        }

        private void StreetTextBox_Validating(object sender, CancelEventArgs e)
        {
            StreetTextBox.Text = StreetTextBox.Text.Trim();
            if (string.IsNullOrEmpty(StreetTextBox.Text))
            {
                errorProvider.SetError(StreetTextBox, "Polje ne smije biti prazno!");
                e.Cancel = true;
                return;
            }
            errorProvider.SetError(StreetTextBox, null);

            var array = StreetTextBox.Text.ToCharArray();

            var numOfSpaces = array.Count(chr => chr == ' ');
            if (numOfSpaces == 1) return;

            var index = StreetTextBox.Text.IndexOf(' ');
            if(index == -1) return;

            StreetTextBox.Text = StreetTextBox.Text.Replace(" ", string.Empty);
            StreetTextBox.Text = StreetTextBox.Text.Insert(index, " ");
        }

        private void OIBTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar == (char)Keys.Back || char.IsNumber(e.KeyChar));
        }

        private void OIBTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (OIBTextBox.Text.Length != 11)
            {
                errorProvider.SetError(OIBTextBox, "OIB mora sadržavati točno 11 znamenki!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(OIBTextBox, null);
            }
        }

        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar == (char)Keys.Back || char.IsNumber(e.KeyChar));
        }

        private void IdTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(IdTextBox.Text))
            {
                errorProvider.SetError(IdTextBox, "Polje ne smije biti prazno!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(IdTextBox, null);
            }
        }

        public bool ShowAddPensionerDialog()
        {
            return ShowDialog() == DialogResult.OK;
        }
    }
}
