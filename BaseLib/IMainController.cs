using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib
{
    public interface IMainController
    {
        void AddPensioner();
        void UpdatePensionerList(IMainForm mainForm);
        void ShowCreatePdfForm();
        void ShowPensionerDetailsForm(string oib);
        void ShowGenerateMutualAidForm();
        void ShowGenerateMembershipForm();
        void GetSearchResults(string filter, IMainForm mainForm);
        void ShowEditSettingsForm();
    }
}
