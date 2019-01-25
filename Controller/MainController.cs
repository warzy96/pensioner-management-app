using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseLib;
using DataAccessLayer;
using Model.Repositories;
using PresentationLayer;

namespace Controller
{
    public class MainController : IMainController
    {
        private readonly IPensionerRepository _pensionerRepository = PensionerRepository.GetInstance();
        private readonly IWindowFormsFactory _formsFactory;

        public MainController(IWindowFormsFactory factory)
        {
            _formsFactory = factory;
        }

        public void AddPensioner()
        {
            var pensionerController = new PensionerController();
            var addPensionerForm = _formsFactory.CreateAddPensionerForm(pensionerController);

            pensionerController.ShowAddPensionerForm(addPensionerForm);
        }

        public void UpdatePensionerList(IMainForm mainForm)
        {
            mainForm.UpdatePensionerListView(_pensionerRepository.GetAll());
        }

        public void ShowCreatePdfForm()
        {
            var form = _formsFactory.CreateCreatePdfForm(new FileController());
            form.ShowCreatePdfForm();
        }

        public void ShowPensionerDetailsForm(string oib)
        {
            var pensionerController = new PensionerController();
            var form = _formsFactory.CreatePensionerDetailsForm(pensionerController, oib);

            pensionerController.ShowPensionerDetailsForm(form);
        }

        public void ShowGenerateMutualAidForm()
        {
            throw new NotImplementedException();
        }

        public void ShowGenerateMembershipForm()
        {
            throw new NotImplementedException();
        }
    }
}
