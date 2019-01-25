using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseLib;
using Model;
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

        public IAddPensionerForm CreateAddPensionerForm(IPensionerController controller)
        {
            return new AddPensionerForm(controller);
        }

        public IPensionerDetailsForm CreatePensionerDetailsForm(IPensionerController controller, string oib)
        {
            return new PensionerDetailsForm(controller, oib);
        }

        public IGenerateTransactionForm CreateGenerateTransactionsForm(ITransactionController transactionController)
        {
            return new GenerateTransactionForm(transactionController);
        }
    }
}
