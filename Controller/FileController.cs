using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            if (_fileService.OutputFile(attributesList))
            {
                MessageBox.Show("Datoteka uspješno spremljena!");
            }
        }
    }
}
