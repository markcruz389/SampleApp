import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-show-user',
  templateUrl: './show-user.component.html',
  styleUrls: ['./show-user.component.css']
})
export class ShowUserComponent implements OnInit {

  constructor(private service:SharedService, private router: Router) { }

  UserList:any = [];

  ModalTitle:string;
  ActivateAddEditUserComp:boolean = false;
  user:any;

  ngOnInit(): void {
    this.refreshDepList();
  }
  
  addClick(){
    this.user = {
      id: 0,
      firstName: "",
      lastName: "",
      email: "",
      password: "",
      userRoleId: 0
    }
    
    this.ModalTitle="Add User";
    this.ActivateAddEditUserComp = true;
  }

  editClick(item:any){
    this.user = item;
    this.ModalTitle="Edit User";
    this.ActivateAddEditUserComp = true;
  }

  deleteClick(item:any){
    if(confirm('Are you sure??')){
      this.service.deleteUser(item).subscribe(data => {
        alert("deleted");
        this.refreshDepList();
      });
    }
  }

  closeClick(){
    this.ActivateAddEditUserComp = false;
    this.refreshDepList();
  }

  logOutClick(){
    this.router.navigate(['login']);
  }

  refreshDepList(){
    this.service.getUserList().subscribe(data=>{
      this.UserList=data;
    });
  }

}
