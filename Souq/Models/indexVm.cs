namespace Souq.Models
{
    //دى عشان اقدر ابعت ال 3 حجات ف ال view 
    public class indexVm
    {
        public indexVm() {         //دا عشان لو فاضى يبعتلى null
            Categories = new List<Category>();
            Products = new List<Product>();
            Reviews = new List<Review>();
            ProductImages = new List<ProductImage>();
            LatestProducts = new List<Product>();
        }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }

        public List<Review> Reviews { get; set; }
        public List<ProductImage> ProductImages { get; set; }

        public List<Product> LatestProducts { get; set; }

    }
}
