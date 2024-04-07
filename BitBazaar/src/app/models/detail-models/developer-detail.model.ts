import { AppModel } from "../app.model";

export interface DeveloperDetailModel{
    id: number,
    createdAt: Date,
    name: string,
    description: string,
    profilePath: string,
    apps: AppModel[]
}