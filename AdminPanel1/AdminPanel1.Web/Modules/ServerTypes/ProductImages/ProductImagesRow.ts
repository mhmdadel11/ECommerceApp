import { fieldsProxy } from "@serenity-is/corelib";

export interface ProductImagesRow {
    Id?: number;
    ProductId?: number;
    Image?: string;
    ProductName?: string;
}

export abstract class ProductImagesRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Image';
    static readonly localTextPrefix = 'ProductImages.ProductImages';
    static readonly deletePermission = 'Images';
    static readonly insertPermission = 'Images';
    static readonly readPermission = 'Images';
    static readonly updatePermission = 'Images';

    static readonly Fields = fieldsProxy<ProductImagesRow>();
}