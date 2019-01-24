using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BaseLib
{
    public interface IPensionerController
    {
        Pensioner GetPensioner(int id);
        Pensioner GetPensioner(string oib);
        void ShowAddPensionerForm(IAddPensionerForm addPensionerForm);
        void AddPensioner(int addPensionerForm, string oib, string name, string surname, DateTime dateOfBirth,
            DateTime membershipStart, string placeOfBirth, string city, string town, string street, int postalCode,
            PaymentType requiredPayment);
    }
}
