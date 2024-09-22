import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface ProductRow {
    Id?: number;
    Name?: string;
    Description?: string;
    Price?: number;
    CatId?: number;
    Photo?: string;
    Type?: string;
    SupplierName?: string;
    EntryDate?: string;
    ReviewUrl?: string;
    Quantity?: number;
    CatName?: string;
}

export abstract class ProductRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Product.Product';
    static readonly lookupKey = 'Product.Product';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<ProductRow>('Product.Product') }
    static async getLookupAsync() { return getLookupAsync<ProductRow>('Product.Product') }

    static readonly deletePermission = 'Product';
    static readonly insertPermission = 'Product';
    static readonly readPermission = 'Product';
    static readonly updatePermission = 'Product';

    static readonly Fields = fieldsProxy<ProductRow>();
}