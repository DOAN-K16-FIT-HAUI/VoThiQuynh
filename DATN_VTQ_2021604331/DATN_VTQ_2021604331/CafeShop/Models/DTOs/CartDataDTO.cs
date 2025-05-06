namespace CafeShop.Models.DTOs
{
    public class CartDataDTO : Cart
    {
        public List<Topping> lstTopping { get; set; }
    }
}
