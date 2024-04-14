export interface CreateReviewModel{
    id:number,
    createdAt: Date,
    title: string,
    description: string,
    recommended: boolean,
    appId: number   
}