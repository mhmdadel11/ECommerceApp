import { ReviewForm, ReviewRow, ReviewService } from '@/ServerTypes/Review';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('AdminPanel1.Review.ReviewDialog')
export class ReviewDialog extends EntityDialog<ReviewRow, any> {
    protected getFormKey() { return ReviewForm.formKey; }
    protected getRowDefinition() { return ReviewRow; }
    protected getService() { return ReviewService.baseUrl; }

    protected form = new ReviewForm(this.idPrefix);
}