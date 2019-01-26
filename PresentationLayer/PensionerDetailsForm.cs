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
using Remotion.Linq.Parsing.Structure.IntermediateModel;

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

            foreach (var payment in _pensioner.Payments)
            {
                PaymentType.TypeEnumNames.TryGetValue(payment.Type.Type, out var paymentName);

                var listViewItem = new ListViewItem(paymentName);
                listViewItem.SubItems.Add(payment.Type.Amount.ToString());
                listViewItem.SubItems.Add(payment.ForYear.Year.ToString());
                listViewItem.SubItems.Add(payment.IsPayed ? "Da" : "Ne");
                listViewItem.SubItems.Add(payment.Id.ToString());
                listViewItem.Checked = payment.IsPayed;
                TransactionsListView.Items.Add(listViewItem);
            }
        }

        public bool ShowPensionerDetailsForm()
        {
            if (_pensioner != null) return ShowDialog() == DialogResult.OK;
            Close();
            MessageBox.Show("Umirovljenik ne postoji!");
            return false;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var confirmMessageBox = MessageBox.Show("Jeste li sigurni da želite obrisati člana?", "Potvrda brisanja",
                MessageBoxButtons.YesNo);

            if (confirmMessageBox == DialogResult.Yes)
            {
                _controller.RemovePensioner(OIBTextBox.Text);
                Close();
            }
        }

        private void PositiveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren()) return;
            
            _pensioner.Name = NameTextBox.Text.Trim();
            _pensioner.Surname = SurnameTextBox.Text.Trim();
            _pensioner.DateOfBirth = DateOfBirthPicker.Value;
            _pensioner.MembershipStart = MemberFromDateTimePicker.Value;
            _pensioner.PlaceOfBirth = PlaceOfBirthTextBox.Text.Trim();
            _pensioner.CurrentAddress.City = CityTextBox.Text.Trim();
            _pensioner.CurrentAddress.Town = TownTextBox.Text.Trim();
            _pensioner.CurrentAddress.Street = StreetTextBox.Text.Trim();
            _pensioner.CurrentAddress.PostalCode = int.Parse(PostalCodeTextBox.Text);

            PaymentType requiredPayment = null;
            if (HighRadioButton.Checked)
            {
                requiredPayment = new PaymentType(PaymentType.TypeEnum.MutualAidHigh, Model.Properties.Settings.Default.MutualAidHighFee, _pensioner);
            }
            else if (LowRadioButton.Checked)
            {
                requiredPayment = new PaymentType(PaymentType.TypeEnum.MutualAidLow, Model.Properties.Settings.Default.MutualAidLowFee, _pensioner);
            }

            _pensioner.RequiredPayments.Remove(_pensioner.RequiredPayments.FirstOrDefault(t =>
                t.Type == PaymentType.TypeEnum.MutualAidHigh || t.Type == PaymentType.TypeEnum.MutualAidLow));
            _pensioner.RequiredPayments.Add(requiredPayment);

            foreach (ListViewItem item in TransactionsListView.Items)
            {
                var transaction = _pensioner.Payments.FirstOrDefault(t => t.Id == int.Parse(item.SubItems[4].Text));

                if (item.Checked)
                {
                    if (transaction != null) transaction.IsPayed = true;
                }
                else
                {
                    if (transaction != null) transaction.IsPayed = false;
                }
            }
            _controller.UpdatePensioner(_pensioner);
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
            e.Handled = !(e.KeyChar == (char)Keys.Back || char.IsNumber(e.KeyChar));
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
            var result = "";
            foreach (var letter in array)
            {
                switch (letter)
                {
                    case ',':
                        continue;
                    case ' ' when result.Last() != ' ':
                        result += letter;
                        break;
                    default:
                        result += letter;
                        break;
                }
            }

            StreetTextBox.Text = result;
        }

        private void DeleteTransactionButton_Click(object sender, EventArgs e)
        {
            DeleteTransactionButton.Enabled = false;
            foreach (ListViewItem selectedItem in TransactionsListView.SelectedItems)
            {
                var payment = _pensioner.Payments.FirstOrDefault(t => t.Id == int.Parse(selectedItem.SubItems[4].Text));
                if (payment != null)
                {
                    _pensioner.Payments.Remove(payment);
                    _controller.RemovePayment(payment);
                }
            }

        }

        private void TransactionsListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (TransactionsListView.SelectedItems.Count > 0)
            {
                DeleteTransactionButton.Enabled = true;
            }
        }
    }
}
