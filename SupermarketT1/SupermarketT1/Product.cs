namespace SupermarketT1
{
    public abstract class Product : Ipay

    {
        public string Description { get; set; }
        public int Id { get; set; }
        public decimal Price { get; set; }
        public float Tax { get; set; }

        public abstract Decimal ValueToPay();

        public override string ToString()
        {
            return $"{Id}- {Description},Price: {Price}, Tax: {Tax}";
        }


    }
}

