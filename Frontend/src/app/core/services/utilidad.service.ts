import { Injectable, inject } from '@angular/core';
import { MatPaginatorIntl } from '@angular/material/paginator';
import { MatSnackBar } from '@angular/material/snack-bar';
// import { Sesion } from '../Interfaces/sesion';

@Injectable({
  providedIn: 'root'
})
export class UtilidadService {
  private snackBar = inject(MatSnackBar);

  mostrarAlerta(mensaje: string, tipo: string): void {
    this.snackBar.open(mensaje, tipo, {
      horizontalPosition: 'end',
      verticalPosition: 'top',
      duration: 3000
    });
  }

  // guardarSesionUsuario(usuarioSession: Sesion): void {
  //   localStorage.setItem('usuario', JSON.stringify(usuarioSession));
  // }

  obtenerSesionUsuario(){
    const dataCatena = localStorage.getItem('usuario');
    const usuario = JSON.parse(dataCatena!);
    return usuario;
  }

  eliminarSesionUsuario(){
    localStorage.removeItem('usuario');
  }

  getSpanishPaginatorIntl(): MatPaginatorIntl {
    const paginatorIntl = new MatPaginatorIntl();

    paginatorIntl.itemsPerPageLabel = 'Registros por página';
    paginatorIntl.nextPageLabel = 'Página siguiente';
    paginatorIntl.previousPageLabel = 'Página anterior';
    paginatorIntl.firstPageLabel = 'Primera página';
    paginatorIntl.lastPageLabel = 'Última página';
    
    paginatorIntl.getRangeLabel = (page: number, pageSize: number, length: number) => {
      if (length === 0 || pageSize === 0) {
        return `0 de ${length}`;
      }
      const startIndex = page * pageSize;
      const endIndex = startIndex < length ?
        Math.min(startIndex + pageSize, length) :
        startIndex + pageSize;
      return `${startIndex + 1} – ${endIndex} de ${length}`;
    };

    return paginatorIntl;
  }
}
