export interface Usuario {
    id: number,
    nombre: string,
    apellido: string,
    gmail: string,
    fechaCreacion: string,
    activo: boolean,
    verificado?: boolean,
    subdivision?: number,
    subdivisionNombre?: string
}
