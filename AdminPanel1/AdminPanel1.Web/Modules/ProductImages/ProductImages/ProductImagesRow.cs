using AdminPanel1.Product;
using AdminPanel1.SouqCom;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace AdminPanel1.ProductImages;

[ConnectionKey("souq"), Module("ProductImages"), TableName("ProductImages")]
[DisplayName("Product Images"), InstanceName("Product Images")]
[ReadPermission("Images")]
[ModifyPermission("Images")]
[ServiceLookupPermission("Images")]
public sealed class ProductImagesRow : Row<ProductImagesRow.RowFields>, IIdRow, INameRow
{
    const string jProduct = nameof(jProduct);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Product"), ForeignKey(typeof(Product.ProductRow)), LeftJoin(jProduct), TextualField(nameof(ProductName))]
    [ServiceLookupEditor(typeof(Product.ProductRow))]
    public int? ProductId { get => fields.ProductId[this]; set => fields.ProductId[this] = value; }

    [DisplayName("Image"), QuickSearch, NameProperty]
    [ImageUploadEditor]
    public string Image { get => fields.Image[this]; set => fields.Image[this] = value; }

    [DisplayName("Product Name"), Origin(jProduct, nameof(Product.ProductRow.Name))]
    public string ProductName { get => fields.ProductName[this]; set => fields.ProductName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public Int32Field ProductId;
        public StringField Image;

        public StringField ProductName;
    }
}