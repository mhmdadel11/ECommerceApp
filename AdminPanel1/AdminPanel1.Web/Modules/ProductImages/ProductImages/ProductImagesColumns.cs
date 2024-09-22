﻿using Serenity.ComponentModel;
using System.ComponentModel;

namespace AdminPanel1.ProductImages.Columns;

[ColumnsScript("ProductImages.ProductImages")]
[BasedOnRow(typeof(ProductImagesRow), CheckNames = true)]
public class ProductImagesColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string ProductName { get; set; }
    [EditLink]
    public string Image { get; set; }
}