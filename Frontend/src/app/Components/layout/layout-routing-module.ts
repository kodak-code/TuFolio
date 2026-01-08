import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LayoutComponent } from './layout.component';
import { UsuarioComponent } from './Pages/usuario/usuario.component';
import { RolComponent } from './Pages/rol/rol.component';

const routes: Routes = [
  {
    path: '',
    component: LayoutComponent,
    children: [
      { path: 'usuario', component: UsuarioComponent },
      { path: 'rol', component: RolComponent }
      
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class LayoutRoutingModule { }
