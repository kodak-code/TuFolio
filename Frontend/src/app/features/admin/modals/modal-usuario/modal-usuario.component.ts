import { Component, Inject } from '@angular/core';
import { SharedModule } from '../../../../shared/shared-module';
import { CommonModule } from '@angular/common';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { Usuario } from '../../../../core/interfaces/usuario';
import { UsuarioService } from '../../../../core/services/usuario.service';
import { UtilidadService } from '../../../../core/services/utilidad.service';

@Component({
  selector: 'app-modal-usuario.component',
  standalone: true,
  imports: [SharedModule, CommonModule],
  templateUrl: './modal-usuario.component.html',
  styleUrl: './modal-usuario.component.css',
})
export class ModalUsuarioComponent {
  formulario: FormGroup;
  tituloAccion = "Crear";
  botonAccion = "Guardar";

  constructor(
    private modalActual: MatDialogRef<ModalUsuarioComponent>,
    @Inject(MAT_DIALOG_DATA) public datosUsuario: Usuario,
    private fb: FormBuilder,
    private _usuarioServicio: UsuarioService,
    private _utilidadServicio: UtilidadService
  ) {
    this.formulario = this.fb.group({
      nombre: ["", Validators.required],
      apellido: ["", Validators.required],
      gmail: ["", Validators.required],
      activo: ["", Validators.required],
      subDivisionNombre: ["", Validators.required]
    });

    if (this.datosUsuario != null) {
      this.tituloAccion = "Editar";
      this.botonAccion = "Actualizar";
    }
  }

  ngOnInit(): void {
    if (this.datosUsuario != null) {
      this.formulario.patchValue({
        nombre: this.datosUsuario.nombre,
        apellido: this.datosUsuario.apellido,
        gmail: this.datosUsuario.gmail,
        activo: this.datosUsuario.activo,
      })
    }
  }

  guardarEditarUsuario() {
    const _usuario: Usuario = {
      id: this.datosUsuario == null ? 0 : this.datosUsuario.id,
      nombre: this.formulario.value.nombre,
      apellido: this.formulario.value.apellido,
      gmail: this.formulario.value.gmail,
      activo: this.formulario.value.activo,
      fechaCreacion: this.datosUsuario?.fechaCreacion ?? new Date().toISOString()
    }

    // crear
    if (this.datosUsuario == null) {
      this._usuarioServicio.crear(_usuario).subscribe({
        next: (data) => {
          if (data.estado) {
            this._utilidadServicio.mostrarAlerta("Usuario Creado con Exito", "EXITO");
            this.modalActual.close("true");
          } else {
            this._utilidadServicio.mostrarAlerta("No se pudo registrar el usuario", "ERROR");
          }
        },
        error: () => {
          this._utilidadServicio.mostrarAlerta("No se pudo registrar el usuario", "ERROR");
        },
      })
    } else {
      // editar
      this._usuarioServicio.editar(_usuario).subscribe({
        next: (data) => {
          if (data.estado) {
            this._utilidadServicio.mostrarAlerta("Usuario Editado con Exito", "EXITO");
            this.modalActual.close("true");
          } else {
            this._utilidadServicio.mostrarAlerta("No se pudo editar el usuario", "ERROR");
          }
        },
        error: () => {
          this._utilidadServicio.mostrarAlerta("No se pudo editar el usuario", "ERROR");
        },
      })
    }
  }
}