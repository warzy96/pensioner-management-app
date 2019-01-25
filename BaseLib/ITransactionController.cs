using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib
{
    public interface ITransactionController
    {
        void GenerateMembershipTransactions(DateTime forYear);

        void GenerateMutualAidTransactions(DateTime forYear);

        void ShowGenerateMutualAidForm(IGenerateTransactionForm form);
    }
}
