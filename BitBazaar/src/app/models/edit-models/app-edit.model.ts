export interface AppEditModel{
    id : number,
    createdAt: Date,
    title: string,
    description: string,
    price: number,
    releaseDate: Date,
    developerId: number,
    genresIdsToAdd: number[],
    genresIdsToRemove: number[],
    titleCardPath: string,
    titleCardFile: File,
    imageIdsToRemove: number[],
    imagesToAdd: File[]
    
}