import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AboutUsComponent } from './about-us/about-us.component';
import { LoginComponent } from './account/login/login.component';
import { RegisterComponent } from './account/register/register.component';
import { AuthGuard } from './guards/auth-guard';
import { WishListComponent } from './wish-list/wish-list.component';

const routes: Routes = [
  {path:'login', component : LoginComponent},
  {path:'register',component:RegisterComponent},
  {path:'wishList', component: WishListComponent, canActivate :[AuthGuard]},
  {path:'aboutUs', component: AboutUsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
