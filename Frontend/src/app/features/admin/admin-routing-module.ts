import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    loadComponent: () => import('./admin.component').then(m => m.AdminComponent),
    children: [
    {
      path: 'usuario',
      loadComponent: () =>
        import('./pages/usuario/usuario.component')
          .then(m => m.UsuarioComponent)
    },
    {
      path: 'rol',
      loadComponent: () =>
        import('./pages/rol/rol.component')
          .then(m => m.RolComponent)
    }
      
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
