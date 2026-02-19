import { Component, ViewChild } from '@angular/core';
import { SharedModule } from '../../../../shared/shared-module';
import { Usuario } from '../../../../core/interfaces/usuario';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, MatPaginatorIntl } from '@angular/material/paginator';
import { MatDialog } from '@angular/material/dialog';
import { UsuarioService } from '../../../../core/services/usuario.service';
import { UtilidadService } from '../../../../core/services/utilidad.service';
import { ModalUsuarioComponent } from '../../modals/modal-usuario/modal-usuario.component';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-usuario.component',
  standalone: true,
  imports: [SharedModule],
  templateUrl: './usuario.component.html',
  styleUrl: './usuario.component.css',
  providers: [
    {
      provide: MatPaginatorIntl, 
      useFactory: (UtilidadService: UtilidadService) => UtilidadService.getSpanishPaginatorIntl(),
      deps: [UtilidadService]
    }
  ]
})
export class UsuarioComponent {
  columnasTabla: string[] = ['nombre', 'apellido', 'gmail', 'activo', 'subDivisionNombre', 'acciones'];
  dataInicio: Usuario[] = [];
  dataListaUsuarios = new MatTableDataSource(this.dataInicio);
  @ViewChild(MatPaginator) paginacionTabla!: MatPaginator;

  constructor(
    private dialog: MatDialog,
    private _usuarioServicio: UsuarioService,
    private _utilidadServicio: UtilidadService
  ) { }

  obtenerUsuarios() {
    this._usuarioServicio.lista().subscribe({
      next: (data) => {
        // console.log('Respuesta API:', data);
        if (data.estado)
          this.dataListaUsuarios.data = data.valor
        else
          this._utilidadServicio.mostrarAlerta("No se encontraron registros", "Opps!");
      },
      error: () => {
        this._utilidadServicio.mostrarAlerta("No se encontraron registros", "Opps!");
      },
    });
  }

  ngOnInit(): void {
    this.obtenerUsuarios();
  }

  ngAfterViewInit(): void {
    // paginacion
    this.dataListaUsuarios.paginator = this.paginacionTabla;
  }
  
  aplicarFiltroTabla(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataListaUsuarios.filter = filterValue.trim().toLocaleLowerCase();
  }

  nuevoUsuario() {
    this.dialog.open(ModalUsuarioComponent, {
      disableClose: true, // No se puede cerrar haciendo clic fuera del modal
    }).afterClosed().subscribe(resultado => {
      if (resultado === 'true')
        this.obtenerUsuarios();
    });
  }

  editarUsuario(usuario: Usuario) {
    this.dialog.open(ModalUsuarioComponent, {
      disableClose: true, // No se puede cerrar haciendo clic fuera del modal
      data: usuario
    }).afterClosed().subscribe(resultado => {
      if (resultado === 'true')
        this.obtenerUsuarios();
    });
  }

  eliminarUsuario(usuario: Usuario) {
    Swal.fire({
      title: '¿Desea desactivar el usuario?',
      text: usuario.nombre,
      icon: 'warning',
      confirmButtonColor: '#3085d6',
      confirmButtonText: 'Sí, desactivar',
      showCancelButton: true,
      cancelButtonColor: '#d33',
      cancelButtonText: 'No, volver'
    })
    .then((resultado) => {
      if (resultado.isConfirmed) {
        this._usuarioServicio.desactivar(usuario.id).subscribe({
          next: (data) => {
            if (data.estado) {
              this._utilidadServicio.mostrarAlerta("El usuario fue eliminado", "Listo!");
              this.obtenerUsuarios();
            } else {
              this._utilidadServicio.mostrarAlerta("No se pudo eliminar el usuario", "Error");
            }
          },
          error: () => {
            this._utilidadServicio.mostrarAlerta("No se pudo eliminar el usuario", "Error");
          }
        });
      }
    })
  }
}
