import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  template: `
    <h2>HRMS Employees</h2>
    <ul>
      <li *ngFor="let emp of employees">{{emp.name}}</li>
    </ul>
  `
})
export class AppComponent implements OnInit {
  employees:any[]=[];
  constructor(private http: HttpClient){}
  ngOnInit(){
    this.http.get<any[]>('http://localhost:5000/api/employees')
      .subscribe(data => this.employees = data);
  }
}