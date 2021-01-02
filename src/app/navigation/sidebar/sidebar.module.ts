import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SidebarComponent } from './sidebar.component';
import { MatDividerModule } from '@angular/material/divider';
import { MatIconModule } from '@angular/material/icon';
import { MatListModule } from '@angular/material/list';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [SidebarComponent],
  imports: [
    CommonModule,
    MatIconModule,
    MatDividerModule,
    MatListModule,
    RouterModule
  ],
  exports: [SidebarComponent]
})
export class SidebarModule { }
