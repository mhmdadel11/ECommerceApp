import { ProductForm, ProductRow, ProductService } from '@/ServerTypes/Product';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('AdminPanel1.Product.ProductDialog')
export class ProductDialog extends EntityDialog<ProductRow, any> {
    protected getFormKey() { return ProductForm.formKey; }
    protected getRowDefinition() { return ProductRow; }
    protected getService() { return ProductService.baseUrl; }

    protected form = new ProductForm(this.idPrefix);
}