using Serenity.ComponentModel;
using System;

namespace AdminPanel1.Product.Forms;

[FormScript("Product.Product")]
[BasedOnRow(typeof(ProductRow), CheckNames = true)]
public class ProductForm
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int CatId { get; set; }
    public string Photo { get; set; }
    public string Type { get; set; }
    public string SupplierName { get; set; }
    public DateTime EntryDate { get; set; }
    public string ReviewUrl { get; set; }
    public int Quantity { get; set; }
}