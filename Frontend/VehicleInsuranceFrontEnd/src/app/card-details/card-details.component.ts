import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { SharedService } from '../services/sharedService';


@Component({
  selector: 'app-card-details',
  templateUrl: './card-details.component.html',
  styleUrls: ['./card-details.component.css']
})
export class CardDetailsComponent implements OnInit {
userId;
public service;
  constructor(private routes:Router,private sharedService:SharedService) 
  {
    this.service=sharedService;
   }



  donePayment()
  {
    this.routes.navigate(["/success"]);
  }
  ngOnInit(): void {
    this.userId=this.service.getuserId();
    if(this.userId==null)
    {
         this.routes.navigate(["/userlogin"]);
    }

    
  }

}
