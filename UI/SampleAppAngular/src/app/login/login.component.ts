import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { SharedService } from '../shared.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private service:SharedService, private router: Router) { }

  Email:string;
  Password:String;
  Login:boolean = true;
  ngOnInit(): void {

  }

  login(){
    var val = {
      Email: this.Email,
      Password: this.Password
    }; 

    this.service.login(val).subscribe(res=>{
      if (res){
        this.router.navigate(['user']);
      }
      else {
        this.router.navigate(['login']);
      }
    });
  }

}
