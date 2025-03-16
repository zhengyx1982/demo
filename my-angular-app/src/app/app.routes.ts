import { Routes } from '@angular/router';
import {FirstComponent} from './first/first.component';
import { SecondComponent } from './second/second.component';
import { LoginComponent } from './login/login.component';
import { RegistryComponent } from './registry/registry.component';
export const routes: Routes = [
  { path: '', redirectTo: 'index', pathMatch: 'full' },
  { path: 'index', component: FirstComponent },
  { path: 'second-component', component: SecondComponent },
  { path: 'login', component: LoginComponent },
  {path: 'register', component: RegistryComponent}
];
