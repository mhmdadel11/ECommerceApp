import { CategoryForm, CategoryRow, CategoryService } from '@/ServerTypes/SouqCom';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('AdminPanel1.SouqCom.CategoryDialog')
export class CategoryDialog extends EntityDialog<CategoryRow, any> {
    protected getFormKey() { return CategoryForm.formKey; }
    protected getRowDefinition() { return CategoryRow; }
    protected getService() { return CategoryService.baseUrl; }

    protected form = new CategoryForm(this.idPrefix);
}