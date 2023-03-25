import { Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { PrimeNGConfig } from 'primeng/api';
import { AuthService } from './shared/services/auth.service';
import { LOGIN_URL } from './shared/constants/urls.const';

@Component({
  selector: 'app-root',
  template: ` <router-outlet></router-outlet> `,
})
export class AppComponent implements OnInit {
  menuMode = 'static';
  constructor(
    private primengConfig: PrimeNGConfig,
    private authService: AuthService,
    private router: Router
  ) {}

  ngOnInit() {
    this.primengConfig.ripple = true;
    document.documentElement.style.fontSize = '16px';
    console.log(this.authService.isAuthenticated());
    if (this.authService.isAuthenticated() == false) {
      this.router.navigate([LOGIN_URL]);
    }
  }
}
