namespace Krav_02.Models
{
    public abstract class Product
    {
        public int ProductId { get; set; }
        public required string Brand { get; set; }
        public required int PricePerDay { get; set; }

    }
}
