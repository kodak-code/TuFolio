import { Routes } from '@angular/router';
import { Login } from './features/auth/pages/login/login';

export const routes: Routes = [
  {
    path: '',
    loadChildren: () =>
      import('./features/landing/landing-module').then(m => m.LandingModule)
  },
  { path: 'login', component: Login },
  {
    path: 'admin',
    loadChildren: () =>
      import('./features/admin/admin-module').then(m => m.AdminModule)
  },

  // Redirección para rutas inválidas
  { path: '**', redirectTo: '', pathMatch: 'full' }
];
