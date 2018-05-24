import { Injectable } from '@angular/core';

@Injectable()
export class AuthenticationService {

  constructor() { }

  public getToken(): string {
    return sessionStorage.getItem('token');
  }




}
