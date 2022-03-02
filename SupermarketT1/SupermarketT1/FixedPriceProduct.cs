using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketT1
{
    public class FixedPriceProduct : Product
    {

        public override decimal ValueToPay()
        {
            decimal value = Price + (Price * (decimal)Tax);
            return value;

        }
        public override string ToString()
        {
            return $"{Id} {Description} " +
                $"\n\t Price......:{$" {Price:C2}",15}" +
                $"\n\t Tax........:{$" {Tax:P2}",15}" +
                $"\n\t Value......:{$" {ValueToPay():C2}",15}";
        }
    }
}