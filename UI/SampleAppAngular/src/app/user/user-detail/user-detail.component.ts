import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-user-detail',
  templateUrl: './user-detail.component.html',
  styleUrls: ['./user-detail.component.css']
})
export class UserDetailComponent implements OnInit {

  constructor(private route: ActivatedRoute, private service:SharedService) { }

  test:any;

  id:any;
  FirstName:string;
  LastName:string;
  Email:string;
  Password:string;
  UserRole:string;

  ngOnInit(): void {
    this.route.paramMap.subscribe(params => { 
      this.id = params.get('id')
    });

    this.service.getUserById(this.id).subscribe(data=>{
      this.FirstName = data.firstName;
      this.LastName = data.lastName;
      this.Email = data.email;
      this.UserRole = data.roleName;
    }); 
  }
}
