using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseLib;
using BaseLib.Service;
using Service;

namespace Controller
{
    public class FileController : IFileController
    {
        private readonly IOutputFileService _fileService;
        public FileController()
        {
            _fileService = PdfService.ProvidePdfService();
        }

        public void CreateFile<T>(IEnumerable<T> attributesList)
        {
            _fileService.OutputFile(attributesList);
        }
    }
}
