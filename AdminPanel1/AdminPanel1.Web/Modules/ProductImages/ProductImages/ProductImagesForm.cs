using Serenity.ComponentModel;

namespace AdminPanel1.ProductImages.Forms;

[FormScript("ProductImages.ProductImages")]
[BasedOnRow(typeof(ProductImagesRow), CheckNames = true)]
public class ProductImagesForm
{
    public int ProductId { get; set; }
    public string Image { get; set; }
}