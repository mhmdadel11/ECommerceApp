import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface CategoryRow {
    Id?: number;
    Name?: string;
    Photo?: string;
    Description?: string;
}

export abstract class CategoryRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'SouqCom.Category';
    static readonly lookupKey = 'SouqCom.Category';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<CategoryRow>('SouqCom.Category') }
    static async getLookupAsync() { return getLookupAsync<CategoryRow>('SouqCom.Category') }

    static readonly deletePermission = 'Category';
    static readonly insertPermission = 'Category';
    static readonly readPermission = 'Category';
    static readonly updatePermission = 'Category';

    static readonly Fields = fieldsProxy<CategoryRow>();
}