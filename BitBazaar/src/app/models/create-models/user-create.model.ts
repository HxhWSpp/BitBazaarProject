export interface UserCreateModel{
    email:string,
    password:string,
    description: string,
    profilePicture: string,
    profileFile: File,
    userName: string
}