namespace PrettyHairLibrary
{
    public class OrderLine
    {
        public ProductType Product { get; set; }
        public int Quantity { get; set; }

        public OrderLine() { }

        public OrderLine(ProductType product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return "\t" + Product.Description + " - " + Quantity;
        }
    }
}