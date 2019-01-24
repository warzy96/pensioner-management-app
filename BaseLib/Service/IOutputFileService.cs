using System.Collections.Generic;

namespace BaseLib.Service
{
    public interface IOutputFileService : IFileService
    {
        bool OutputFile<T>(IEnumerable<T> attributes);
    }
}
