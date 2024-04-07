export interface DeveloperCreateModel{
    id: number,
    createdAt: Date,
    name: string,
    description: string,
    profilePath?: string,
    profileFile: File
}