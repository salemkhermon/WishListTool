import { Component, OnInit } from '@angular/core';
import { LoginService } from 'src/app/services/login.service';
import { sidebarAnimation, iconAnimation, labelAnimation } from 'src/app/animations';
import { SidebarService } from '../service/sidebar.service';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.scss'],
  animations :[
    sidebarAnimation(),
    iconAnimation(),
    labelAnimation(),
  ]
})
export class SidebarComponent implements OnInit {
  sidebarState = "";
  isExpanded = true;
  showSubmenu: boolean = false;
  isShowing = false;
  showSubSubMenu: boolean = false;

  constructor(private sidebarService: SidebarService ,public accountService :LoginService) { }

  ngOnInit(): void {
    this.sidebarService.sidebarStateObservable$.
      subscribe((newState: string) => {
        this.sidebarState = newState;
      });
  }

}
