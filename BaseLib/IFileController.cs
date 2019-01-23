using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib
{
    public interface IFileController
    {
        void CreateFile<T>(IEnumerable<T> attributesList);
    }
}
