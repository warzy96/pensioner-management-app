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

        private readonly BaseFont _font = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, false);
        private const int FontSize = 12;
        private const string FileName = "Zapis";
        private const string Ext = ".pdf";
        private const int MarginSize = 10;
        
        public static IOutputFileService ProvidePdfService()
        {
            return _service ?? (_service = new PdfService());
        }
        public bool OutputFile<T>(IEnumerable<T> attributes)
        {

            var folderBrowserDialog = FolderBrowserDialogService.GetInstance();

            if (folderBrowserDialog.ShowDialog() != DialogResult.OK) return false;

            var filePath = folderBrowserDialog.GetPath();

            var document = new Document(PageSize.A4, MarginSize, MarginSize, MarginSize, MarginSize);
            var writer = PdfWriter.GetInstance(document, new FileStream(GetFilePathAndName(filePath), FileMode.Create));

            var regularFont = new Font(_font, FontSize, Font.NORMAL);

            var attributeList = attributes.ToList();

            var table = new PdfPTable(attributeList.Count) {WidthPercentage = 100};

            var allPensioners = _repository.GetAllWithRequiredPayments();

            AddAttributes(table, attributeList);
            foreach (var pensioner in allPensioners)
            {
                foreach (var attribute in attributeList)
                {
                    PdfPCell cell;
                    switch (Enum.GetName(typeof(Enums.OutputAttributes), attribute))
                    {
                        case Enums.FullName:
                        {
                            cell = new PdfPCell(new Phrase(pensioner.GetFullName(), regularFont));
                            table.AddCell(cell);
                            break;
                        }
                        case Enums.OibEnumName:
                        {
                            cell = new PdfPCell(new Phrase(pensioner.Oib, regularFont));
                            table.AddCell(cell);
                            break;
                        }
                        case Enums.IdEnumName:
                        {
                            cell = new PdfPCell(new Phrase(pensioner.Id.ToString(), regularFont));
                            table.AddCell(cell);
                            break;
                        }
                        case Enums.CityAndZipCodeEnumName:
                        {
                            cell = new PdfPCell(new Phrase(pensioner.CurrentAddress.GetCityAndZipCode(), regularFont));
                            table.AddCell(cell);
                            break;
                        }
                        case Enums.MutualAidEnumName:
                        {
                            cell = new PdfPCell(new Phrase(pensioner.GetMutualAidRequiredPaymentString(), regularFont));
                            table.AddCell(cell);
                            break;
                        }
                        case Enums.MembershipEnumName:
                        {
                            cell = new PdfPCell(new Phrase(pensioner.GetMembershipRequiredPaymentString(), regularFont));
                            table.AddCell(cell);
                            break;
                        }
                        case Enums.PlaceOfResidenceEnumName:
                        {
                            cell = new PdfPCell(new Phrase(pensioner.CurrentAddress.GetPlaceOfResidence(), regularFont));
                            table.AddCell(cell);
                            break;
                        }
                    }
                }
            }

            document.Open();
            document.Add(table);

            document.Close();
            writer.Close();

            return true;
        }

        private void AddAttributes<T>(PdfPTable table, IEnumerable<T> attributes)
        {
            var boldFont = new Font(_font, FontSize, Font.BOLD);

            foreach (var attribute in attributes)
            {
                PdfPCell cell;
                switch (Enum.GetName(typeof(Enums.OutputAttributes), attribute))
                {
                    case Enums.FullName:
                    {
                        cell = new PdfPCell(new Phrase(Enums.FullName_HR, boldFont));
                        table.AddCell(cell);
                        break;
                    }
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
                    case Enums.MutualAidEnumName:
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

        private string GetFilePathAndName(string path)
        {
            var fileNumber = 0;
            while (File.Exists(path + FileName + fileNumber + Ext))
            {
                fileNumber++;
            }

            return path + FileName + fileNumber + Ext;
        }
    }
}
