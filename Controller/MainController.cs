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
            var addPensionerForm = _formsFactory.CreateAddPensionerForm(_pensionerRepository);
            if (addPensionerForm.ShowAddPensionerDialog())
            {
                MessageBox.Show("Član uspješno spremljen!");
            }
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
    }
}
