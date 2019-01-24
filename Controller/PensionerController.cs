using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseLib;
using DataAccessLayer;
using Model;
using Model.Repositories;

namespace Controller
{
    public class PensionerController: IPensionerController
    {
        private readonly IPensionerRepository _pensionerRepository = PensionerRepository.GetInstance();

        public Pensioner GetPensioner(int id)
        {
            return _pensionerRepository.GetPensioner(id);
        }

        public Pensioner GetPensioner(string oib)
        {
            return _pensionerRepository.GetPensionerWithAllAttributes(oib);
        }

        public void ShowAddPensionerForm(IAddPensionerForm addPensionerForm)
        {
            if (addPensionerForm.ShowAddPensionerDialog())
            {
                MessageBox.Show("Član uspješno spremljen!");
            }
        }

        public void AddPensioner(int id, string oib, string name, string surname, DateTime dateOfBirth, DateTime membershipStart,
            string placeOfBirth, string city, string town, string street, int postalCode, PaymentType requiredPayment)
        {
            _pensionerRepository.AddPensioner(id, oib, name, surname, dateOfBirth, membershipStart, placeOfBirth, city,
                town, street, postalCode, requiredPayment);
        }

        public void RemovePensioner(string oib)
        {
            _pensionerRepository.RemovePensioner(oib);
        }

        public void ShowPensionerDetailsForm(IPensionerDetailsForm form)
        {
            form.ShowPensionerDetailsForm();
        }
    }
}
