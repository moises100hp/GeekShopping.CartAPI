namespace GeekShopping.CartAPI.Data.ValueObjects
{
    public class CouponVO
    {
        public long Id { get; set; }
        public string CuponCode { get; set; }
        public decimal DiscountAmouth { get; set; }
    }
}
