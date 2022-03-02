using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketT1
{
    public class Invoice : Ipay
    {
        private ICollection<Product> _Products;

        public Invoice()
        {
            _Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _Products.Add(product);
        }
        public decimal ValueToPay()
        {
            decimal value = 0;
            foreach (Product productc in _Products)
            {
                value += productc.ValueToPay();

            }
            return value;
        }
        public override string ToString()
        {
            string productname = "";
            foreach (Product productc in _Products)
            {
                productname += $"\n" + productc.ToString() + ", ";
            }


            return $" RECEIPT \n------------------------------------" +
                $"\n\tProduct...: {productname}" +
                $"\n\t                 ================" +
                $"\n\tTOTAL:          {$" {ValueToPay():C2}",15}";

        }


    }
}
