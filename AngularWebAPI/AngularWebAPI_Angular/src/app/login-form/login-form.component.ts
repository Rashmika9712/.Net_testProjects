import { LoginDetailService } from './../shared/login-detail.service';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.css']
})
export class LoginFormComponent implements OnInit {

  constructor(public service: LoginDetailService) { }

  ngOnInit(): void {
  }

  onSubmit(form: NgForm){
    this.service.postLogin().subscribe(
      (res) => {
        console.log("Submitted successfully to database");
      },
      (err) => {
        console.log(err);
      }
    )
  }
}
