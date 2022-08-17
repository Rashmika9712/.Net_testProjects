import { LoginDetail } from './login-detail.model';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LoginDetailService {

  constructor(private http: HttpClient) { }

  formData: LoginDetail = new LoginDetail();
  readonly baseUrl = 'http://localhost:58707/api/Logins';

  postLogin(){
    return this.http.post(this.baseUrl, this.formData);
  }
}
