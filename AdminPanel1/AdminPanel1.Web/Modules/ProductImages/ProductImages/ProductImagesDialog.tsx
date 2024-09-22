import { ProductImagesForm, ProductImagesRow, ProductImagesService } from '@/ServerTypes/ProductImages';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('AdminPanel1.ProductImages.ProductImagesDialog')
export class ProductImagesDialog extends EntityDialog<ProductImagesRow, any> {
    protected getFormKey() { return ProductImagesForm.formKey; }
    protected getRowDefinition() { return ProductImagesRow; }
    protected getService() { return ProductImagesService.baseUrl; }

    protected form = new ProductImagesForm(this.idPrefix);
}