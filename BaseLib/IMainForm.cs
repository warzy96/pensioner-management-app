using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BaseLib
{
    public interface IMainForm
    {
        void UpdatePensionerListView(IEnumerable<Pensioner> pensioners);
    }
}
