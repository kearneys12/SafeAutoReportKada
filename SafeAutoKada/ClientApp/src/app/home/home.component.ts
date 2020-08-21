import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent {
  Report: Array<object> = new Array;
  constructor(private httpClient : HttpClient) {}
  GetReport() {
    this.httpClient.get("/GetReport").subscribe((data: Array<object>) => {
      this.Report = data
      
    });
   
  }
}
 
