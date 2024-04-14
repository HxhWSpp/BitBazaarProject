import { ImageModel } from "./image.model";

export interface AppModel{
    id: number,
    title: string,
    description: string,
    titleCardPath: string,
    price: number,
    releaseDate: Date,
    images:  ImageModel[]
}