import { Routes } from '@angular/router';
import { LoginComponent } from './Components/login/login.component';

export const routes: Routes = [
  { path: 'login', component: LoginComponent },

  {
    path: 'pages',
    loadChildren: () =>
      import('./Components/layout/layout-module').then(m => m.LayoutModule)
  },

  // Redirección para rutas inválidas
  { path: '**', redirectTo: 'login', pathMatch: 'full' }
];
