using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseLib;
using DataAccessLayer;
using PresentationLayer;

namespace Controller
{
    public class MainController : IMainController
    {
        private readonly PensionerRepository _pensionerRepository = PensionerRepository.GetInstance();

        public MainController()
        {
        }

        public void AddPensioner()
        {
            var addPensionerForm = new AddPensionerForm(_pensionerRepository);
            addPensionerForm.ShowDialog();
        }

        public void UpdatePensionerList(IMainForm mainForm)
        {
            mainForm.UpdatePensionerListView(_pensionerRepository.GetAll());
        }
    }
}
