import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { LoginComponent } from './login/login.component'; 
import { UserDetailComponent } from './user/user-detail/user-detail.component';
import { UserComponent } from './user/user.component'; 

const routes: Routes = [
  {path:'login',component:LoginComponent},
  {path:'user',component:UserComponent},
  {path:'user-detail',component:UserDetailComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
