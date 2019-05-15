import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-contacts',
  templateUrl: './contacts.component.html',
  styleUrls: ['./contacts.component.css']
})
export class ContactsComponent implements OnInit {

  constructor() { }

  contacts = [
    { name: 'Sean', title: 'Consultant', blurb: 'Hello World', photo: 'assets/images/stockimage1.jpg', icon: 'accessibility'},
    { name: 'Dustin', title: 'The Boss', blurb: 'Goodbye World', photo: 'assets/images/stockimage2.jpg', icon: 'face'}
  ]
  
  ngOnInit() {
  }

}
