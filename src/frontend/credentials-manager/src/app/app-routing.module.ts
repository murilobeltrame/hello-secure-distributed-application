import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TenantsComponent } from './tenants/tenants.component';
import { UsersComponent } from './users/users.component';

const routes: Routes = [
  {path:'users', component: UsersComponent},
  {path:'tenants', component:TenantsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
