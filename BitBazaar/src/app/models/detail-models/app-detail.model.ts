import { DeveloperModel } from "../developer.model";
import { GenreModel } from "../genre.model";
import { ImageModel } from "../image.model";
import { ReviewModel } from "../review.model";

export interface AppDetailModel{
    createdAt: Date,
    id: number,
    title: string,
    description: string,
    titleCardPath: string,
    price: number,
    releaseDate: Date,
    genres: GenreModel[],
    images: ImageModel[],
    developer?: DeveloperModel,
    reviews: ReviewModel[]

}