namespace SupermarketT1
{
    public class VariablePriceProduct : Product
    {
        public String Measurement { get; set; }
        public float Quantity { get; set; }

        public override decimal ValueToPay()
        {
            decimal value = (Price * (decimal)Quantity);
            decimal value1 = value * (decimal)Tax;
            value = value1 + value;

            return value;
        }

        public override string ToString()
        {
            return $"{Id} {Description} \n\t Measurement: {Measurement}" +
                $"\n\t Quantity...:{$" {Quantity:N2}",15}" +
                $"\n\t Price......:{$" {Price:C2}",15}" +
                $"\n\t Tax........:{$" {Tax:P2}",15}" +
                $"\n\t Value......:{$" {ValueToPay():C2}",15}";

        }

    }
}
