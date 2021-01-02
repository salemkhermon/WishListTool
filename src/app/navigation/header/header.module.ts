import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from './header.component';
import { MatToolbarModule } from '@angular/material/toolbar';
import { ToggleSidebarModule } from '../toggle-sidebar/toggle-sidebar.module';
import { MatListModule } from '@angular/material/list';
import { MatIconModule } from '@angular/material/icon';



@NgModule({
  declarations: [HeaderComponent],
  imports: [
    CommonModule,
    ToggleSidebarModule,
    MatToolbarModule,
    MatListModule,
    MatIconModule
  ],
  exports : [HeaderComponent]
})
export class HeaderModule { }
