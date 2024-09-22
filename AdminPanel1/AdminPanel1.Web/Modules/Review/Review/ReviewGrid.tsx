import { ReviewColumns, ReviewRow, ReviewService } from '@/ServerTypes/Review';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ReviewDialog } from './ReviewDialog';

@Decorators.registerClass('AdminPanel1.Review.ReviewGrid')
export class ReviewGrid extends EntityGrid<ReviewRow> {
    protected getColumnsKey() { return ReviewColumns.columnsKey; }
    protected getDialogType() { return ReviewDialog; }
    protected getRowDefinition() { return ReviewRow; }
    protected getService() { return ReviewService.baseUrl; }
}