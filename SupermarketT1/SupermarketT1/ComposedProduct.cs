namespace SupermarketT1
{

    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public ICollection<Product> Products;

        public override decimal ValueToPay()
        {

            decimal Payrroll = 0;
            decimal discountproduct = 0;
            decimal validatingp = 0;
            foreach (Product productc in Products)
            {
                Payrroll += productc.ValueToPay();

            }
            discountproduct = Payrroll * (decimal)Discount;
            validatingp = Payrroll - discountproduct;
            return validatingp;
        }
        public override string ToString()
        {
            String productname = "";
            foreach (Product productc in Products)
            {
                productname += productc.Description + ", ";
            }

            return $"{Id}  {Description} " +
                $"\n\t Products...: { productname} " +
                $"\n\t Discount...:{($" {Discount:P2}"),15}" +
                $"\n\t Value......:{($" {ValueToPay():C2}"),15}";

        }

    }
}
