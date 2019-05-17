import { Component, OnInit } from '@angular/core';
import { Person } from './Person';
import moment from 'moment-timezone';
import { FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-create-contact',
  templateUrl: './create-contact.component.html',
  styleUrls: ['./create-contact.component.css']
})
export class CreateContactComponent implements OnInit {
  postalCodeRegEx = /^[A-Za-z]\d[A-Za-z]\d[A-Za-z]\d$/;

  person = new Person();
  postalCode = new FormControl( this.person.address.postalCode, [Validators.required, Validators.pattern( this.postalCodeRegEx )]);

  isCool = false;

  ngOnInit(): void {
    this.person.name = 'Sean';
    this.person.birthdate = moment('1981-01-23').tz('America/Halifax');

    this.postalCode.registerOnChange( () => {});

    this.isPersonCool( null );
  }

  isPersonCool( event ){
    this.isCool = this.person.name === 'Sean';
  }

}
