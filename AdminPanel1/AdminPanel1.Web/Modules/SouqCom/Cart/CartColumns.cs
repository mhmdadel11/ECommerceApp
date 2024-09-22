﻿using Serenity.ComponentModel;
using System.ComponentModel;

namespace AdminPanel1.SouqCom.Columns;

[ColumnsScript("SouqCom.Cart")]
[BasedOnRow(typeof(CartRow), CheckNames = true)]
public class CartColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string UserId { get; set; }
    public string ProductName { get; set; }
    public int Qty { get; set; }
}