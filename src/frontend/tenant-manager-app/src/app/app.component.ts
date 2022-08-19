import { Component, OnInit } from '@angular/core';
import { KeycloakService } from 'keycloak-angular';
import { KeycloakProfile } from 'keycloak-js';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  public isLoggedIn = false
  public userProfile?: KeycloakProfile

  constructor(private readonly keycloak: KeycloakService) { }

  async ngOnInit(): Promise<void> {
    this.isLoggedIn = await this.keycloak.isLoggedIn()
    if (this.isLoggedIn) {
      this.userProfile = await this.keycloak.loadUserProfile()
    }
  }

  public login () {
    this.keycloak.login()
  }

  public logout () {
    this.keycloak.logout()
  }
}
