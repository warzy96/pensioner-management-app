using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Repositories;

namespace BaseLib
{
    public interface IWindowFormsFactory
    {
        ICreatePdfForm CreateCreatePdfForm(IFileController fileController);
        IAddPensionerForm CreateAddPensionerForm(IPensionerRepository repository);

    }
}
