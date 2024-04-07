import { AppModel } from "../app.model";


export interface GenreDetailModel {
    id: number,
    name: string,
    apps: AppModel[]
}