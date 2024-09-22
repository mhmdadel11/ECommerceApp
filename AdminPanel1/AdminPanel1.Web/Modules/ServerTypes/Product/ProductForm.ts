import { StringEditor, DecimalEditor, LookupEditor, ImageUploadEditor, DateEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ProductForm {
    Name: StringEditor;
    Description: StringEditor;
    Price: DecimalEditor;
    CatId: LookupEditor;
    Photo: ImageUploadEditor;
    Type: StringEditor;
    SupplierName: StringEditor;
    EntryDate: DateEditor;
    ReviewUrl: StringEditor;
    Quantity: IntegerEditor;
}

export class ProductForm extends PrefixedContext {
    static readonly formKey = 'Product.Product';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ProductForm.init)  {
            ProductForm.init = true;

            var w0 = StringEditor;
            var w1 = DecimalEditor;
            var w2 = LookupEditor;
            var w3 = ImageUploadEditor;
            var w4 = DateEditor;
            var w5 = IntegerEditor;

            initFormType(ProductForm, [
                'Name', w0,
                'Description', w0,
                'Price', w1,
                'CatId', w2,
                'Photo', w3,
                'Type', w0,
                'SupplierName', w0,
                'EntryDate', w4,
                'ReviewUrl', w0,
                'Quantity', w5
            ]);
        }
    }
}