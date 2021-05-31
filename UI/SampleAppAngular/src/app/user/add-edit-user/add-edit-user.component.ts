import { Component, OnInit, Input } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-add-edit-user',
  templateUrl: './add-edit-user.component.html',
  styleUrls: ['./add-edit-user.component.css']
})
export class AddEditUserComponent implements OnInit {

  constructor(private service:SharedService) { }

  RoleList:any[];

  @Input() user:any;
  Id:number;
  FirstName:string;
  LastName:string;
  Email:string;
  Password:string;
  UserRoleId:number;

  ngOnInit(): void {
    this.Id = this.user.id;
    this.FirstName = this.user.firstName;
    this.LastName = this.user.lastName;
    this.Email = this.user.email;
    this.Password = this.user.password;
    this.UserRoleId = this.user.userRoleId;
    
    this.service.getUserRoleList().subscribe(data=>{
      this.RoleList=data;
    });
  }
  
  addUser(){
    var val = {
      Id: this.Id,
      FirstName: this.FirstName,
      LastName: this.LastName,
      Email: this.Email,
      Password: this.Password,
      UserRoleId: this.UserRoleId
    }

    this.service.addUser(val).subscribe(res=>{
      alert("added");
    });
  }
  
  updateUser(){
    var val = {
      Id: this.Id,
      FirstName: this.FirstName,
      LastName: this.LastName,
      Email: this.Email,
      Password: this.Password,
      UserRoleId: this.UserRoleId
    }

    this.service.updateUser(val).subscribe(res=>{
      alert("updated");
    });
  }

}
