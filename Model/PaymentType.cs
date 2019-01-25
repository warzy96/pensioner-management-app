using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PaymentType
    {
        public const string Empty = "-";
        public enum TypeEnum
        {
            Membership = 1, 
            MutualAidLow,
            MutualAidHigh,
            MutualAid
        }

        public static readonly Dictionary<TypeEnum, string> TypeEnumNames = new Dictionary<TypeEnum,string>()
        {
            {TypeEnum.Membership, "Članarina"},
            {TypeEnum.MutualAidLow, "Niža uzajamna pomoć"},
            {TypeEnum.MutualAidHigh, "Viša uzajamna pomoć"},
            {TypeEnum.MutualAid, "Uzajamna pomoć" }
        };

        public virtual int Id { get; set; }
        public virtual Pensioner Pensioner { get; set; }
        public virtual TypeEnum Type { get; set; }
        public virtual double Amount { get; set; }

        public PaymentType()
        {

        }

        public PaymentType(TypeEnum type, double amount)
        {
            Type = type;
            Amount = amount;
        }
        public PaymentType(TypeEnum type, double amount, Pensioner pensioner)
        {
            Type = type;
            Amount = amount;
            Pensioner = pensioner;
        }
    }
}
