import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialModule } from './material.module';
import { DashboardModule } from './dashboard/dashboard.module';
import { HeaderModule } from './navigation/header/header.module';
import { SidebarModule } from './navigation/sidebar/sidebar.module';
import { ToggleSidebarModule } from './navigation/toggle-sidebar/toggle-sidebar.module';
import { AccountModule } from './account/account.module';
import { WishListComponent } from './wish-list/wish-list.component';
import { ReactiveFormsModule } from '@angular/forms';
import { AboutUsComponent } from './about-us/about-us.component';
import { HttpClientModule } from '@angular/common/http';



@NgModule({
  declarations: [
    AppComponent,
    WishListComponent,
    AboutUsComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MaterialModule,
    DashboardModule,
    HeaderModule,
    SidebarModule,
    ToggleSidebarModule,
    AccountModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
