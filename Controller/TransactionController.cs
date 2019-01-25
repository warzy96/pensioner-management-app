using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseLib;
using DataAccessLayer;
using Model;
using Model.Repositories;

namespace Controller
{
    public class TransactionController : ITransactionController
    {
        private readonly IPensionerRepository _repository = PensionerRepository.GetInstance();
        public void GenerateMembershipTransactions(DateTime forYear)
        {
            _repository.GenerateMembershipTransactions(forYear);
        }

        public void GenerateMutualAidTransactions(DateTime forYear)
        {
            _repository.GenerateMutualAidTransactions(forYear);
        }

        public void ShowGenerateMutualAidForm(IGenerateTransactionForm form)
        {
            PaymentType.TypeEnumNames.TryGetValue(PaymentType.TypeEnum.MutualAid, out var titleValue);
            form.ShowGenerateTransactionForm(titleValue);
        }

        public void ShowGenerateMembershipForm(IGenerateTransactionForm form)
        {
            PaymentType.TypeEnumNames.TryGetValue(PaymentType.TypeEnum.Membership, out var titleValue);
            form.ShowGenerateTransactionForm(titleValue);
        }
    }
}
