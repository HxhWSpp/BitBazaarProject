import { AppModel } from "../app.model";

export interface UserDetailModel{
    id: string,
    userName: string,
    description: string,
    profilePicture: string,
    wallet: number,
    appsLibrary: AppModel[],
    appsWishlist: AppModel[],
}