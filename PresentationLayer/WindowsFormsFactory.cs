using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseLib;
using Model.Repositories;

namespace PresentationLayer
{
    public class WindowsFormsFactory : IWindowFormsFactory
    {
        public ICreatePdfForm CreateCreatePdfForm(IFileController fileController)
        {
            var createPdfForm = new CreatePdfForm(fileController);

            return createPdfForm;
        }

        public IAddPensionerForm CreateAddPensionerForm(IPensionerRepository repository)
        {
            return new AddPensionerForm(repository);
        }
    }
}
