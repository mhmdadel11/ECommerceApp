using Serenity.ComponentModel;

namespace AdminPanel1.SouqCom.Forms;

[FormScript("SouqCom.Cart")]
[BasedOnRow(typeof(CartRow), CheckNames = true)]
public class CartForm
{
    public string UserId { get; set; }
    public int ProductId { get; set; }
    public int Qty { get; set; }
}