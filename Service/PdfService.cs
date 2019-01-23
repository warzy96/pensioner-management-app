using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseLib;
using BaseLib.Service;
using DataAccessLayer;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Model.Repositories;

namespace Service
{
    public class PdfService : IOutputFileService
    {
        private static IOutputFileService _service;
        private readonly IPensionerRepository _repository = PensionerRepository.GetInstance();

        private const Font.FontFamily FontName = Font.FontFamily.HELVETICA;
        private const int FontSize = 12;
        private const string FileName = "Zapis.pdf";
        
        public static IOutputFileService ProvidePdfService()
        {
            return _service ?? (_service = new PdfService());
        }
        public void OutputFile<T>(IEnumerable<T> attributes)
        {

            var folderBrowserDialog = FolderBrowserDialogService.GetInstance();
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK) return;
            var filePath = folderBrowserDialog.GetPath();
            var document = new Document(PageSize.A4, 10, 10, 10, 10);
            var writer = PdfWriter.GetInstance(document, new FileStream(filePath + FileName, FileMode.Create));

            var regularFont = new Font(FontName, FontSize, Font.NORMAL);

            var attributeList = attributes.ToList();
            var table = new PdfPTable(attributeList.Count);
            var allPensioners = _repository.GetAll();

            AddAttributes(table, attributeList);
            foreach (var pensioner in allPensioners)
            {
                var cell = new PdfPCell(new Phrase(pensioner.Name + " " + pensioner.Surname, regularFont));
                table.AddCell(cell);
                //TODO: Add data
            }

            document.Open();
            document.Add(table);
            document.Close();
            writer.Close();
        }

        private void AddAttributes<T>(PdfPTable table, IEnumerable<T> attributes)
        {
            var boldFont = new Font(Font.FontFamily.HELVETICA, FontSize, Font.BOLD);

            var cell = new PdfPCell(new Phrase(Enums.NameAndSurname_HR, boldFont));
            table.AddCell(cell);
            foreach (var attribute in attributes)
            {
                switch (Enum.GetName(typeof(Enums.OutputAttributes), attribute))
                {
                    case Enums.OibEnumName:
                    {
                        cell = new PdfPCell(new Phrase(Enums.OibEnumName_HR, boldFont));
                        table.AddCell(cell);
                        break;
                    }
                    case Enums.IdEnumName:
                    {
                        cell = new PdfPCell(new Phrase(Enums.IdEnumName_HR, boldFont));
                        table.AddCell(cell);
                        break;
                    }
                    case Enums.CityAndZipCodeEnumName:
                    {
                        cell = new PdfPCell(new Phrase(Enums.CityAndZipCodeEnumName_HR, boldFont));
                        table.AddCell(cell);
                        break;
                    }
                    case Enums.MutualAidEnumName_HR:
                    {
                        cell = new PdfPCell(new Phrase(Enums.MutualAidEnumName_HR, boldFont));
                        table.AddCell(cell);
                        break;
                    }
                    case Enums.MembershipEnumName:
                    {
                        cell = new PdfPCell(new Phrase(Enums.MembershipEnumName_HR, boldFont));
                        table.AddCell(cell);
                        break;
                    }
                    case Enums.PlaceOfResidenceEnumName:
                    {
                        cell = new PdfPCell(new Phrase(Enums.PlaceOfResidenceEnumName_HR, boldFont));
                        table.AddCell(cell);
                        break;
                    }
                }
            }
        }
    }
}
