using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib
{
    public static class Enums
    {
        public const string FullName = "FullName";
        public const string OibEnumName = "OIB";
        public const string IdEnumName = "Id";
        public const string PlaceOfResidenceEnumName = "PlaceOfResidence";
        public const string CityAndZipCodeEnumName = "CityAndZipCode";
        public const string MembershipEnumName = "Membership";
        public const string MutualAidEnumName = "MutualAid";

        public const string FullName_HR = "Ime i prezime";
        public const string OibEnumName_HR = "OIB";
        public const string IdEnumName_HR = "Broj knjižice";
        public const string PlaceOfResidenceEnumName_HR = "Adresa";
        public const string CityAndZipCodeEnumName_HR = "Grad i poštanski broj";
        public const string MembershipEnumName_HR = "Članarina";
        public const string MutualAidEnumName_HR = "Uzajamna pomoć";
        public enum OutputAttributes
        {
            OIB,
            Id,
            PlaceOfResidence,
            CityAndZipCode,
            Membership,
            MutualAid,
            FullName
        }

        public enum OutputFileType
        {
            Pdf,
            Csv
        }
    }
}
