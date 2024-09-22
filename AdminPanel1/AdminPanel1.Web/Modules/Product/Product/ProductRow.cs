using AdminPanel1.SouqCom;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace AdminPanel1.Product;

[ConnectionKey("souq"), Module("Product"), TableName("Product")]
[DisplayName("Product"), InstanceName("Product")]
[ReadPermission("Product")]
[ModifyPermission("Product")]
[ServiceLookupPermission("Product")]
[LookupScript]
public sealed class ProductRow : Row<ProductRow.RowFields>, IIdRow, INameRow
{
    const string jCat = nameof(jCat);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Name"), QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Description")]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("Price"), Size(18)]
    public decimal? Price { get => fields.Price[this]; set => fields.Price[this] = value; }

    [DisplayName("Cat"), ForeignKey("Category", "Id"), LeftJoin(jCat), TextualField(nameof(CatName))]
    [LookupEditor(typeof(CategoryRow))]
    public int? CatId { get => fields.CatId[this]; set => fields.CatId[this] = value; }

    [DisplayName("Photo"),ImageUploadEditor]
    public string Photo { get => fields.Photo[this]; set => fields.Photo[this] = value; }

    [DisplayName("Type"), Column("type"), Size(50)]
    public string Type { get => fields.Type[this]; set => fields.Type[this] = value; }

    [DisplayName("Supplier Name"), Size(50)]
    public string SupplierName { get => fields.SupplierName[this]; set => fields.SupplierName[this] = value; }

    [DisplayName("Entry Date")]
    public DateTime? EntryDate { get => fields.EntryDate[this]; set => fields.EntryDate[this] = value; }

    [DisplayName("Review Url")]
    public string ReviewUrl { get => fields.ReviewUrl[this]; set => fields.ReviewUrl[this] = value; }

    [DisplayName("Quantity")]
    public int? Quantity { get => fields.Quantity[this]; set => fields.Quantity[this] = value; }

    [DisplayName("Cat Name"), Expression($"{jCat}.[Name]")]
    public string CatName { get => fields.CatName[this]; set => fields.CatName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Name;
        public StringField Description;
        public DecimalField Price;
        public Int32Field CatId;
        public StringField Photo;
        public StringField Type;
        public StringField SupplierName;
        public DateTimeField EntryDate;
        public StringField ReviewUrl;
        public Int32Field Quantity;

        public StringField CatName;
    }
}