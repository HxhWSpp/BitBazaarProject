export interface AppCreateModel {
    id: number,
    createdAt: Date,
    title: string,
    description: string,
    price: number,
    releaseDate: Date,
    genreIds: number[],
    developerId: number,
    titleCardPath?: string,
    titleCardFile: File,
    imagePaths?: string[],
    imageFiles: File[]
  }