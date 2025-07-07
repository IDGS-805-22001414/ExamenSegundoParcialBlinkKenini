import { Routes } from '@angular/router';
import { PrincipalComponent } from './components/principal/principal';
import { ProductosComponent } from './components/productos/productos';

export const routes: Routes = [
  { path: '', component: PrincipalComponent },
  { path: 'productos', component: ProductosComponent }
];
