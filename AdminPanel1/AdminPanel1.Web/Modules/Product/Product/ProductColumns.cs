using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace AdminPanel1.Product.Columns;

[ColumnsScript("Product.Product")]
[BasedOnRow(typeof(ProductRow), CheckNames = true)]
public class ProductColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string CatName { get; set; }
    public string Photo { get; set; }
    public string Type { get; set; }
    public string SupplierName { get; set; }
    public DateTime EntryDate { get; set; }
    public string ReviewUrl { get; set; }
    public int Quantity { get; set; }
}