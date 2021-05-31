import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { NgStyle } from '@angular/common';

@Injectable({
  providedIn: 'root'
})
export class SharedService {
  readonly APIUrl = "http://localhost:23613/api";

  constructor(private http:HttpClient) { }

  getUserList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/User/all')
  }

  getUserById(val:any){
    return this.http.get<any>(this.APIUrl+'/User/'+val)
  }

  addUser(val:any){
    return this.http.post(this.APIUrl+'/User',val)
  }

  updateUser(val:any){
    return this.http.put(this.APIUrl+'/User/update',val)
  }

  deleteUser(val:any){
    return this.http.delete(this.APIUrl+'/User/delete/'+val);
  }
  
  getUserRoleList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/UserRole/all');
  }

  login(val:any){
    return this.http.post(this.APIUrl+'/User/login',val);
  }
}
