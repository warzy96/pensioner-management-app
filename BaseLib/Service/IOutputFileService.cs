using System.Collections.Generic;

namespace BaseLib.Service
{
    public interface IOutputFileService : IFileService
    {
        void OutputFile<T>(IEnumerable<T> attributes);
    }
}
